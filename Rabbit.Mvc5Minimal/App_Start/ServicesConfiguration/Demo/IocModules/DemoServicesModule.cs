using Rabbit.IOC;
using Rabbit.Mvc5Minimal.App_Start.ServicesConfiguration.Demo.Services;
using SimpleInjector;
using SimpleInjector.Packaging;

namespace Rabbit.Mvc5Minimal.App_Start.ServicesConfiguration.Demo.IocModules
{
    public class DemoServicesModule : ModuleBase, IPackage
    {
        public void RegisterServices(Container container)
        {
            container.RegisterPerWebRequest<IListingService, DefaultListingService>();
        }
    }
}