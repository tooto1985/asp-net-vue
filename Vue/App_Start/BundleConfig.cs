using System.Web;
using System.Web.Optimization;

namespace Vue
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/vue").Include(
                        "~/Scripts/vue.js",
                        "~/Scripts/vue-router.js",
                        "~/Scripts/main.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                        "~/Content/site.css"));
        }
    }
}
