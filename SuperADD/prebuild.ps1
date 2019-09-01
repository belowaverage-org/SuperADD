Write-Host "Packaging SuperADDDaemon..."
Compress-Archive -Path "SuperADDDaemon\*" -DestinationPath "Resources\SuperADDDaemon.zip" -Force
Write-Host "Done!"