# the base image
FROM mcr.microsoft.com/dotnet/framework/aspnet:4.8-20200512-windowsservercore-1903 

# copy all application files
COPY ./PublishOutput/ /inetpub/wwwroot

# copy startup folder
COPY ./Startup /Startup

# change entrypoint to startup script
#ENTRYPOINT ["powershell.exe", "C:\\Startup\\Startup.ps1"]
ENTRYPOINT ["powershell.exe", "C:\\Startup\\StartupTransform.ps1"]