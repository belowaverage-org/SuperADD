Param(
    [Parameter(Mandatory=$true,
    ValueFromPipeline=$true)]
    [String]
    $DomainName,

    [Parameter(Mandatory=$true,
    ValueFromPipeline=$true)]
    [String]
    $ComputerName,

    [Parameter(Mandatory=$true,
    ValueFromPipeline=$true)]
    [String]
    $UserName,

    [Parameter(Mandatory=$true,
    ValueFromPipeline=$true)]
    [String]
    $Password,

    [Parameter(Mandatory=$false,
    ValueFromPipeline=$true)]
    [Switch]
    $Base64
)

if($Base64) {
    $UserName = [System.Text.Encoding]::UTF8.GetString([System.Convert]::FromBase64String($UserName))
    $Password = [System.Text.Encoding]::UTF8.GetString([System.Convert]::FromBase64String($Password))
}

$Credential = New-Object pscredential -ArgumentList ([pscustomobject]@{
    UserName = $UserName
    Password = (ConvertTo-SecureString -String $Password -AsPlainText -Force)[0]
})

if([System.Environment]::MachineName.ToLower() -eq $ComputerName.ToLower()) {
    Add-Computer -Domain $DomainName -Credential $Credential
} else {
    Add-Computer -Domain $DomainName -Credential $Credential -NewName $ComputerName
}