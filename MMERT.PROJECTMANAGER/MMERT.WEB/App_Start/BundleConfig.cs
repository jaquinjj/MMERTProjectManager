using System.Web;
using System.Web.Optimization;

namespace MMERT.WEB
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                        "~/Content/css/arjuna.css",
                        "~/Content/css/bootstrap.min.css",
                        "~/Content/css/tasks.css",
                        "~/Content/css/table-responsive.css",
                        "~/Content/css/table-responsive.css",
                        "~/Content/js/carousel/owl.carousel.css",
                        "~/Content/js/carousel/owl.theme.css",
                        "~/Content/js/carousel/owl.transitions.css"
                        ));

            bundles.Add(new StyleBundle("~/theme/gorevcss").Include(
                        "~/Themes/css/smoothness/jquery-ui.css"

                        ));
            bundles.Add(new  ScriptBundle("~/theme/gorevjs").Include(
                        "~/Content/js/jquery-1.11.1.js",
                        "~/Themes/js/jquery-ui.js"
                        ));

            bundles.Add(new StyleBundle("~/theme/css").Include(
                        "~/Themes/css/bootstrap.css",
                        "~/Themes/css/bootstrap-reset.css",
                        "~/Themes/css/arjuna.css",
                        "~/Themes/css/owl.carousel.css",
                        "~/Themes/css/font-awesome.min.css",
                        "~/Themes/css/owl.theme.css",
                        "~/Themes/css/owl.transitions.css",
                        "~/Themes/css/tasks.css"

                        ));
            bundles.Add(new ScriptBundle("~/theme/js").Include(
                        "~/Themes/js/bootstrap.js",
                        "~/Themes/js/jquery-1.11.1.js",
                        "~/Themes/js/arjuna.js",
                        "~/Themes/js/owl.carousel.js",
                        "~/Themes/js/tasks.js" 
                        ));

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                        "~/Content/js/advanced.component.js",
                        "~/Content/js/arjuna.js",
                        "~/Content/js/bootstrap.min.js",
                        "~/Content/js/draggable-portlet.js",
                        "~/Content/js/editable-table.js",
                        "~/Content/js/form-validation-script.js",
                        "~/Content/js/form.component.js",
                        "~/Content/js/jquery-1.11.1.js",
                        "~/Content/js/jquery.stepy.js",
                        "~/Content/js/jquery.tagsinput.js",
                        "~/Content/js/jquery.validate.min.js",
                        "~/Content/js/morris-script.js",
                        "~/Content/js/nestable.js",
                        "~/Content/js/owl-carousel.js",
                        "~/Content/js/slider.js",
                        "~/Content/js/tasks.js",
                        "~/Content/js/carousel/owl.carousel.js"
                        ));


            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));
        }
    }
}