using System.Web.Optimization;

namespace MaintenanceMode
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/style.css"));
        }
    }
}
