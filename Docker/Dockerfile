# the base image
FROM mcr.microsoft.com/dotnet/framework/aspnet:4.8-20200512-windowsservercore-1903 

# create two volumes
VOLUME c:/Logs

# create two drives L:\ => C:\Logs
#SHELL ["powershell.exe", "-Command"]

#RUN Set-ItemProperty -path 'HKLM:\SYSTEM\CurrentControlSet\Control\Session Manager\DOS Devices' -Name 'L:' -Value '\??\C:\Logs' -Type String;


# copy all application files
COPY ./PublishOutput/ /inetpub/wwwroot
