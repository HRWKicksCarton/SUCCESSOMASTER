using System.Web;
using System.Web.Optimization;

namespace Successo
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add( new ScriptBundle("~/bundles/scripts").Include(
                "~/Content/style.css",
                "~/Content/bootstrap.min.css",
                "~/Content/responsive.css",
                "~/Content/font-awesome.min.css",
                "~/Content/effects/set2.css",
                "~/Content/effects/normalize.css",
                "~/Content/effects/component.css"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Scripts/jquery.min.js",
                      "~/Scripts/nav.js",
                      "~/Scripts/custom.js",
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/effects/masonry.pkgd.min.js",
                      "~/Scripts/effects/imagesloaded.js",
                      "~/Scripts/effects/classie.js",
                      "~/Scripts/effects/AnimOnScroll.js",
                      "~/Scripts/effects/modernizr.custom.js",
                      "~/Scripts/html5shiv.js"));

            BundleTable.EnableOptimizations = true;
        }
    }
}
