using Rabbit.IOC;
using Rabbit.SimpleInjectorDemo.Services;
using SimpleInjector;
using SimpleInjector.Packaging;

namespace Rabbit.SimpleInjectorDemo.IocModules
{
    public class DemoServicesModule : ModuleBase, IPackage
    {
        public void RegisterServices(Container container)
        {
            container.Register<IListingService, DefaultListingService>(Lifestyle.Scoped);
        }
    }
}