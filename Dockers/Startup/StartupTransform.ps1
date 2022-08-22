# override web.config file if available
$envTransform = "C:\EnvConfig\WebTransform.config"

if (Test-Path $envTransform) {
	C:\Startup\WebConfigTransformRunner\WebConfigTransformRunner.exe C:\inetpub\wwwroot\Web.config $envTransform C:\inetpub\wwwroot\Web.config
}

# monitor the iis service
C:\ServiceMonitor.exe w3svc
