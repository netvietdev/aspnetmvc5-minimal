using System.Web.Optimization;

namespace Rabbit.Mvc5Minimal.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;

            bundles.Add(new ScriptBundle("~/bundles/jquery", "//ajax.aspnetcdn.com/ajax/jQuery/jquery-2.1.4.min.js")
                .Include("~/Scripts/jquery-2.*"));

            bundles.Add(new ScriptBundle("~/bundles/jquery1", "//ajax.aspnetcdn.com/ajax/jQuery/jquery-1.11.3.min.js")
                .Include("~/Scripts/jquery-1.*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap", "//ajax.aspnetcdn.com/ajax/bootstrap/3.3.5/bootstrap.min.js")
                .Include("~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/bootstrap", "//cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.3.5/css/bootstrap.min.css")
                .Include("~/Content/bootstrap.css"));

            bundles.Add(new StyleBundle("~/Content/css")
                .Include("~/Content/site.css"));
        }
    }
}