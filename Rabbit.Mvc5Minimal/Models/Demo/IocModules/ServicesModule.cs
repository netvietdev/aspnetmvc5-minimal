using Rabbit.IOC;
using Rabbit.Mvc5Minimal.Models.Demo.Services;
using SimpleInjector;
using SimpleInjector.Packaging;

namespace Rabbit.Mvc5Minimal.Models.Demo.IocModules
{
    public class ServicesModule : ModuleBase, IPackage
    {
        public void RegisterServices(Container container)
        {
            container.RegisterPerWebRequest<IListingService, DefaultListingService>();
        }
    }
}