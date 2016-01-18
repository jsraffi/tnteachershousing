﻿using System.Web;
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
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/styles").Include(
                      "~/Content/assets/css/bootstrap.css",
                      "~/Content/assets/css/Site.css",
                      "~/Content/assets/css/style.css",
                      "~/Content/assets/css/font-awesome.css"));

            bundles.Add(new StyleBundle("~/Content/mainmenu").Include(
                        "~/Content/assets/js/mainmenu/sticky.css",
                        "~/Content/assets/js/mainmenu/bootstrap.css",
                        "~/Content/assets/js/mainmenu/fhmm.css"));
        }
    }
}
