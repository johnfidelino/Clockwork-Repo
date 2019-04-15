using System.Web;
using System.Web.Optimization;

namespace Clockwork.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                        "~/Content/bootstrap.css",
                        "~/Content/font-awesome.css",
                        "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/momentjs").Include(
                        "~/Scripts/moment.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/datatables").Include(
                        "~/Content/dt/buttons.bootstrap.css",
                        "~/Content/dt/buttons.dataTables.css",
                        "~/Content/dt/dataTableData.css",
                        "~/Content/dt/dataTables.bootstrap.css",
                        "~/Content/dt/dataTables.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/datatables").Include(
                        "~/Scripts/dt/jquery.dataTables.js",
                        "~/Scripts/dt/datatables.bootstrap.js",
                        "~/Scripts/dt/datatables.buttons.js",
                        "~/Scripts/dt/buttons.bootstrap.js",
                        "~/Scripts/dt/buttons.html5.js",
                        "~/Scripts/dt/dataTables.min.js"));
        }
    }
}