<?php //SuperADD Daemon
ini_set('html_errors', false);
if(!empty($_POST)) {
	header('Content-Type: text/plain');
}
if( //Verify POST Values are set.
	isset($_POST['domaincontroller']) && !empty($_POST['domaincontroller']) && 
	isset($_POST['domainname']) && !empty($_POST['domainname']) && 
	isset($_POST['basedn']) && !empty($_POST['basedn']) &&
	isset($_POST['username']) && !empty($_POST['username']) &&
	isset($_POST['password']) && !empty($_POST['password']) &&
	isset($_POST['function']) && !empty($_POST['function'])
) {
	$ldap = ldap_connect($_POST['domaincontroller']); //LDAP Connect.
	ldap_set_option($ldap, LDAP_OPT_REFERRALS, 0); //LDAP Set options for root searching.
	ldap_set_option($ldap, LDAP_OPT_PROTOCOL_VERSION, 3);
	if(ldap_bind($ldap, $_POST['username'].'@'.$_POST['domainname'], $_POST['password'])) { //Check if LDAP is connected.
		if($_POST['function'] == 'list' && isset($_POST['filter']) && !empty($_POST['filter'])) { //List a specified OU.
			$computers = array();
			$cookie = '';
			$attributes = array('CN','description');
			if(isset($_POST['includegroups'])) { //If deamon to include groups.
				array_push($attributes, 'memberOf');
			}
			do {
				ldap_control_paged_result($ldap, 100, true, $cookie);
					if(isset($_POST['recurse'])) { //If recurse search requested, run ldap_search(Recursive Search) instead of ldap_list(Single Level Search)
						$result = ldap_search($ldap, $_POST['basedn'], $_POST['filter'], $attributes, 0, 0); //Run the list search.
					} else {
						$result = ldap_list($ldap, $_POST['basedn'], $_POST['filter'], $attributes); //Run the list search.
					}
					foreach(ldap_get_entries($ldap, $result) as $v) { //Clean raw ldap_list output into an array.
						$desc = '';
						if(isset($v['description']) && $v['description']['count'] == 1) {
							$desc = $v['description'][0];
						}
						if(isset($v['cn']) && $v['cn']['count'] == 1) { //If CN is given.
							if(isset($_POST['includegroups'])) { //If daemon should include groups.
								$groups = array();
								if(isset($v['memberof'])) {
									foreach($v['memberof'] as $k => $group) { //Foreach of the groups, add to array.
										if($k !== 'count') {
											array_push($groups, $group);
										}
									}
								}
								array_push($computers, array('cn' => $v['cn'][0], 'description' => $desc, 'groups' => $groups)); //Add computer object to final output.
							} else {
								array_push($computers, array('cn' => $v['cn'][0], 'description' => $desc)); //Add computer object to final output.
							}
						}
					}
				ldap_control_paged_result_response($ldap, $result, $cookie);
			} while($cookie !== null && $cookie != '');
			echo json_encode($computers); //Convert result array to JSON then output.
            exit;
		}
		if( //Create / modify a computer object.
			$_POST['function'] == 'update' &&
			isset($_POST['cn']) && !empty($_POST['cn']) &&
			isset($_POST['destinationdn']) && !empty($_POST['destinationdn']) &&
			isset($_POST['description'])
		) {
			$cn_escaped = ldap_escape($_POST['cn'], null, LDAP_ESCAPE_DN); //Filter API input.
			$filter_escaped = ldap_escape($_POST['cn'], null, LDAP_ESCAPE_FILTER);
			$new_dn = 'CN='.$cn_escaped.','.$_POST['destinationdn']; //Get full DN.
			$existing = ldap_search($ldap, $_POST['basedn'], 'sAMAccountName='.strtoupper($filter_escaped).'$'); //Search for existing computers that have the same sAMAccountName.
			$existing_dn = @ldap_get_dn($ldap, ldap_first_entry($ldap, $existing)); //If one is found, get the DN.
			if(empty($_POST['description'])) { //If description is empty, change it to a blank array for LDAP call purposes.
				$_POST['description'] = array();
			}
			if($existing_dn !== null && isset($_POST['confirm'])) { //If computer exists, modify only if confirm is sent.
				if($existing_dn !== $new_dn) { //If computers DN is in a different OU than the existing computer, move it.
					$cn = 'CN='.$cn_escaped;
					if(!@ldap_rename($ldap, $existing_dn, $cn, $_POST['destinationdn'], true)) { //Move the computer.
						echo 'Existing computer object found in another OU. Failed to move it to the new OU. ';
                        exit;
					}
				}
				if(!@ldap_mod_replace($ldap, $new_dn, array( //Modify the computer.
					'description' => $_POST['description']
				))) {
					echo 'Failed to modify the existing computer object.';
                    exit;
				}
			} elseif($existing_dn !== null) { //If computer exists, but no confirm, send error code.
				echo 'confirm';
                exit;
			} else {
				$attributes = array( //Create the computer.
					'cn' => $cn_escaped,
					'sAMAccountName' => strtoupper($cn_escaped).'$',
					'objectClass' => 'computer',
					'userAccountControl' => 4096,
					'description' => $_POST['description']
				);
				if(empty($_POST['description'])) {
					unset($attributes['description']);
				}
				if(!@ldap_add($ldap, 'CN='.$cn_escaped.','.$_POST['destinationdn'], $attributes)) { //Create the computer.
					echo 'Failed to create a new computer object in this OU.';
                    exit;
				}
			}
            if(isset($_POST['addgroups']) && !empty($_POST['addgroups'])) {
                //todo
            }
		}
	} else {
		echo 'Could not connect to LDAP server.';
        exit;
	}
} else {
	if(isset($_POST['superadd'])) { //Are we talking to SuperADD? Or the web interface?
		echo "Incorrect parameters.";
        exit;
	} else {
		echo file_get_contents('documentation.html');
        exit;
	}
}
?>