using Rabbit.IOC;
using SimpleInjector;
using SimpleInjector.Packaging;
using System.Configuration;

namespace Rabbit.Business.DbTest.IoC
{
    public class SimpleDbRunnerModule : ModuleBase, IPackage
    {
        public void RegisterServices(Container container)
        {
            if (bool.Parse(ConfigurationManager.AppSettings["UseDatabaseTest"]))
            {
                container.Register<ISimpleRunnerService, SimpleDbRunnerService>(Lifestyle.Scoped);
            }
            else
            {
                container.Register<ISimpleRunnerService, NoDbRunnerService>(Lifestyle.Scoped);
            }                
        }
    }
}