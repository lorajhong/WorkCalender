using System.Web;
using System.Web.Optimization;

namespace WorkCalender
{
    public class BundleConfig
    {
        // 如需統合的詳細資訊，請瀏覽 https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));
            
            //FullCalender JS
            bundles.Add(new ScriptBundle("~/bundles/fullcalender")
                .Include(
                "~/Scripts/Fullcalender/core/main.min.js",
                "~/Scripts/Fullcalender/core/locales-all.min.js",
                "~/Scripts/Fullcalender/daygrid/main.min.js",
                "~/Scripts/Fullcalender/google-calendar/main.min.js",
                "~/Scripts/Fullcalender/interaction/main.min.js",
                "~/Scripts/Fullcalender/list/main.min.js",
                "~/Scripts/Fullcalender/luxon/main.min.js",
                "~/Scripts/Fullcalender/moment/main.min.js",
                "~/Scripts/Fullcalender/moment-timezone/main.min.js",
                "~/Scripts/Fullcalender/rrule/main.min.js",
                "~/Scripts/Fullcalender/timegrid/main.min.js"));

            // 使用開發版本的 Modernizr 進行開發並學習。然後，當您
            // 準備好可進行生產時，請使用 https://modernizr.com 的建置工具，只挑選您需要的測試。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            //FullCalender Css
            bundles.Add(new StyleBundle("~/Content/fullcalendercss")
                .Include(
                "~/Content/Fullcalender/core/main.min.css",
                "~/Content/Fullcalender/daygrid/main.min.css",
                "~/Content/Fullcalender/list/main.min.css",
                "~/Content/Fullcalender/timegrid/main.min.css"));
        }
    }
}
