using Elmah.Mvc;
using Rabbit.IOC;
using Rabbit.Mvc5Minimal;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using SimpleInjector.Packaging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using WebActivator;

[assembly: PostApplicationStartMethod(typeof(SimpleInjectorInitializer), "Initialize")]

namespace Rabbit.Mvc5Minimal
{
    public static class SimpleInjectorInitializer
    {
        /// <summary>Initialize the container and register it as MVC3 Dependency Resolver.</summary>
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            InitializeContainer(container);

            container.RegisterMvcControllers(
                typeof(SimpleInjectorInitializer).Assembly,
                typeof(ElmahController).Assembly);

            container.Verify();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }

        private static void InitializeContainer(Container container)
        {
            var assemblies = GetAllAssemblies().ToArray();

            ModuleHelper.GetModuleTypes(assemblies)
                .CreateModules()
                .Cast<IPackage>()
                .ToList()
                .ForEach(x => x.RegisterServices(container));
        }

        private static IEnumerable<Assembly> GetAllAssemblies()
        {
            var binPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin");

            var excludes = new List<string>
            {
                "System.",
                "SimpleInjector.",
                "Microsoft.",
                "Newtonsoft.",
                "WebActivator.",
                "WebGrease."
            };

            return Directory.GetFiles(binPath, "*.dll")
                .Where(x => !excludes.Any(y =>
                {
                    var fileName = Path.GetFileName(x);
                    return (fileName != null) && fileName.StartsWith(y);
                }))
                .Select(Assembly.LoadFile);
        }
    }
}