using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using Rabbit.IOC;
using Rabbit.Mvc5Minimal;
using Rabbit.Mvc5Minimal.Controllers;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using SimpleInjector.Packaging;
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

            container.RegisterMvcControllers(typeof(HomeController).Assembly);

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

            return Directory.GetFiles(binPath, "*.dll")
                .Where(x => !x.StartsWith("System."))
                .Select(Assembly.LoadFile);
        }
    }
}