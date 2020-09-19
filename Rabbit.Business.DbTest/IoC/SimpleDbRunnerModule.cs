using Rabbit.IOC;
using SimpleInjector;
using SimpleInjector.Packaging;

namespace Rabbit.Business.DbTest.IoC
{
    public class SimpleDbRunnerModule : ModuleBase, IPackage
    {
        public void RegisterServices(Container container)
        {
            container.Register<ISimpleRunnerService, SimpleDbRunnerService>(Lifestyle.Scoped);
        }
    }
}