using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace ShoppingSite
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/js/owl.carousel.min.js",
                "~/js/jquery.sticky.js",
                "~/js/jquery.easing.1.3.min.js"
                ));
            bundles.Add(new ScriptBundle("~/bundle/bootstrap").Include(
                "~/js/main.js",
                "~/js/bxslider.min.js",
                "~/js/script.slider.js"
                ));
            bundles.Add(new StyleBundle("~/bundle/Styles").Include(
                "~/style.css"
                ));
            bundles.Add(new StyleBundle("~/bundles/bootsrapStyle").Include(
                "~/css/bootstrap.min.css",
                "~/css/font-awesome.min.css",
                "~/css/owl.carousel.css",
                "~/css/responsive.css"
                ));

            BundleTable.EnableOptimizations = true;

        }
    }
}