using System.Web;
using System.Web.Optimization;

namespace tnteachershousing
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive-ajax.js",
                        "~/Scripts/jquery.validate*",
                         "~/Scripts/jquery.validate.unobtrusive.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/styles").Include(
                      "~/Content/assets/css/bootstrap.css",
                      "~/Content/assets/css/bootstrapValign.css",
                      "~/Content/assets/css/Site.css",
                      "~/Content/assets/css/style.css",
                      "~/Content/assets/css/font-awesome.css"));

            bundles.Add(new StyleBundle("~/Content/mainmenu").Include(
                        "~/Content/assets/js/mainmenu/sticky.css",
                        "~/Content/assets/js/mainmenu/bootstrap.css",
                        "~/Content/assets/js/mainmenu/fhmm.css"));

            bundles.Add(new StyleBundle("~/Content/styleadmin").Include(
                        "~/Content/Admin/css/reset.css",
                        "~/Content/Admin/css/bootstrap.css",
                        "~/Content/Admin/css/AdminLTE.css",
                        "~/Content/Admin/css/skin-blue.css",
                        "~/Content/Admin/css/font-awesome.min.css",
                        "~/Content/Admin/css/Site.css"));

            bundles.Add(new ScriptBundle("~/bundles/javascript").Include(
                      "~/Scripts/jQuery-2.1.4.min.js",
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/app.js",
                      "~/Scripts/respond.js"));

        }
    }
}
