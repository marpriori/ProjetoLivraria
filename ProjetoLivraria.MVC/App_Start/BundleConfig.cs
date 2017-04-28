using System.Web;
using System.Web.Optimization;

namespace ProjetoLivraria.MVC
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

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Gentelella/css").Include(
                "~/Gentelella/vendors/bootstrap/dist/css/bootstrap.min.css",
                "~/Gentelella/vendors/nprogress/nprogress.css",
                "~/Gentelella/vendors/iCheck/skins/flat/green.css",
                "~/Gentelella/vendors/bootstrap-progressbar/css/bootstrap-progressbar-3.3.4.min.css",
                "~/Gentelella/vendors/jqvmap/dist/jqvmap.min.css",
                "~/Gentelella/vendors/bootstrap-daterangepicker/daterangepicker.css",
                "~/Gentelella/build/css/custom.css",
                "~/Content/font-awesome.css"));

            bundles.Add(new ScriptBundle("~/Gentelella/scripts").Include(
                "~/Gentelella/vendors/jquery/dist/jquery.min.js",
                "~/Gentelella/vendors/bootstrap/dist/js/bootstrap.min.js",
                "~/Gentelella/vendors/fastclick/lib/fastclick.js",
                "~/Gentelella/vendors/nprogress/nprogress.js",
                "~/Gentelella/vendors/Chart.js/dist/Chart.min.js",
                "~/Gentelella/vendors/gauge.js/dist/gauge.min.js",
                "~/Gentelella/vendors/bootstrap-progressbar/bootstrap-progressbar.min.js",
                "~/Gentelella/vendors/iCheck/icheck.min.js",
                "~/Gentelella/vendors/skycons/skycons.js",
                "~/Gentelella/vendors/Flot/jquery.flot.js",
                "~/Gentelella/vendors/Flot/jquery.flot.pie.js",
                "~/Gentelella/vendors/Flot/jquery.flot.time.js",
                "~/Gentelella/vendors/Flot/jquery.flot.stack.js",
                "~/Gentelella/vendors/Flot/jquery.flot.resize.js",
                "~/Gentelella/vendors/flot.orderbars/js/jquery.flot.orderBars.js",
                "~/Gentelella/vendors/flot-spline/js/jquery.flot.spline.min.js",
                "~/Gentelella/vendors/flot.curvedlines/curvedLines.js",
                "~/Gentelella/vendors/DateJS/build/date.js",
                "~/Gentelella/vendors/jqvmap/dist/jquery.vmap.js",
                "~/Gentelella/vendors/jqvmap/dist/maps/jquery.vmap.world.js",
                "~/Gentelella/vendors/jqvmap/examples/js/jquery.vmap.sampledata.js",
                "~/Gentelella/vendors/moment/min/moment.min.js",
                "~/Gentelella/vendors/bootstrap-daterangepicker/daterangepicker.js",
                "~/Gentelella/build/js/custom.js"));
        }
    }
}
