using Rabbit.Configuration;
using Rabbit.IOC;
using SimpleInjector;
using SimpleInjector.Packaging;

namespace Rabbit.Mvc5Minimal.App_Start.ServicesConfiguration
{
    public class ServicesModule : ModuleBase, IPackage
    {
        public void RegisterServices(Container container)
        {
            container.RegisterSingleton<IConfiguration, EnvironmentAwareAppSettingsConfiguration>();
        }
    }
}