# aspnetmvc5-minimal
Rabbit MVC5 Starter Template -> An optimized template for ASP.NET MVC5 project

Rabbit MVC5 Starter Template is ready-to-use template for your application with following features: JQuery 1 or JQuery 3, Bootstrap 3, SimpleInjector, Log4Net with structured logging extension

# Build docker image
docker build -t test/aspnetmvcminimal .

# Start the docker container
docker run -d -p 8080:80 test/aspnetmvcminimal

# Start the docker with a mapped volume
docker run -d -p 8080:80 -v D:\Wip\Practices\OpenSource\aspnetmvc5-minimal\Dockers\TEST-ENV:C:\EnvConfig test/aspnetmvcminimal