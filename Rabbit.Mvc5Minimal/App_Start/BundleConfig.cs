using Rabbit.Foundation.Configuration;
using System.Web.Mvc;
using System.Web.Optimization;

namespace Rabbit.Mvc5Minimal.App_Start
{
    public class BundleConfig
    {
        private static IConfiguration Configuration
        {
            get
            {
                return DependencyResolver.Current.GetService<IConfiguration>();
            }
        }

        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;

            bundles.Add(new ScriptBundle("~/bundles/jquery", Configuration.Get("cdn:JQuery"))
                .Include("~/Scripts/jquery-2.*"));

            bundles.Add(new ScriptBundle("~/bundles/jquery1", Configuration.Get("cdn:JQuery1"))
                .Include("~/Scripts/jquery-1.*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap", Configuration.Get("cdn:Bootstrap"))
                .Include("~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/bootstrap", Configuration.Get("cdn:BootstrapCss"))
                .Include("~/Content/bootstrap.css"));

            bundles.Add(new StyleBundle("~/Content/css")
                .Include("~/Content/site.css"));
        }
    }
}
