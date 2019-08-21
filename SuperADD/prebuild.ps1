Write-Host "Packaging SuperADDServer..."
Compress-Archive -Path "SuperADDServer\*" -DestinationPath "Resources\SuperADDServer.zip" -Force
Write-Host "Done!"