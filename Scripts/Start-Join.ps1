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
    $Password
)

$UserName = [System.Text.Encoding]::UTF8.GetString([System.Convert]::FromBase64String($UserName))
$Password = [System.Text.Encoding]::UTF8.GetString([System.Convert]::FromBase64String($Password))

foreach ($char in "``", "$", "`"") {
    $Password = $Password.Replace($char, "``$($char)")
}

$Script = [Convert]::ToBase64String([System.Text.Encoding]::Unicode.GetBytes("

Write-Host `"Waiting for Lite Touch to finish...`"

`$BDDRunning = `$true
while (`$BDDRunning) {
    Start-Sleep -Milliseconds 500
    `$BDDRunning = (Get-Process -Name BDDRun -ErrorAction SilentlyContinue).Count -gt 0
}

Write-Host `"Clearing Connections...`"

Start-Process -FilePath `"net.exe`" -ArgumentList `"use`", `"*`", `"/delete`", `"/y`" -Wait

Stop-Service -Name `"Remote Desktop Configuration`" -ErrorAction SilentlyContinue
Stop-Service -Name `"Netlogon`" -ErrorAction SilentlyContinue
Stop-Service -Name `"Workstation`" -ErrorAction SilentlyContinue

Start-Service -Name `"Workstation`" -ErrorAction SilentlyContinue
Start-Service -Name `"Netlogon`" -ErrorAction SilentlyContinue
Start-Service -Name `"Remote Desktop Configuration`" -ErrorAction SilentlyContinue

`$Credential = New-Object pscredential -ArgumentList ([pscustomobject]@{
    UserName = `"$UserName`"
    Password = (ConvertTo-SecureString -String `"$Password`" -AsPlainText -Force)[0]
})

Write-Host `"Joining Domain...`"

if([System.Environment]::MachineName.ToLower() -eq `"$ComputerName`".ToLower()) {
    Add-Computer -Domain `"$DomainName`" -Credential `$Credential
} else {
    Add-Computer -Domain `"$DomainName`" -Credential `$Credential -NewName `"$ComputerName`"
}

Start-Sleep -Seconds 5

Write-Host `"Done.`"

Restart-Computer

"))

Start-Process -FilePath "powershell.exe" -ArgumentList "-encodedCommand", $Script
