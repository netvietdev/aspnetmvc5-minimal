# override web.config file if available
$envWebConfig = "C:\EnvConfig\Web.config"

if (Test-Path $envWebConfig) {
	Copy-Item -Path $envWebConfig -Destination C:/inetpub/wwwroot -Force
}

# monitor the iis service
C:\ServiceMonitor.exe w3svc
