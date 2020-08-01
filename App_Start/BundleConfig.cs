using System.Web;
using System.Web.Optimization;

namespace PaginaWebMasicsa
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                          "~/Content/lib/jquery/jquery.min.js",
                          "~/Content/lib/bootstrap/js/bootstrap.min.js",
                          "~/Content/lib/owlcarousel/owl.carousel.min.js",
                          "~/Content/lib/venobox/venobox.min.js",
                          "~/Content/lib/knob/jquery.knob.js",
                          "~/Content/lib/wow/wow.min.js",
                          "~/Content/lib/parallax/parallax.js",
                          "~/Content/lib/easing/easing.min.js",
                          "~/Content/lib/nivo-slider/js/jquery.nivo.slider.js",
                          "~/Content/lib/appear/jquery.appear.js",
                          "~/Content/lib/isotope/isotope.pkgd.min.js",
                          "~/Content/contactform/contactform.js",
                          "~/Content/js/main.js"
                       ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                          "~/Content/lib/bootstrap/css/bootstrap.min.css",
                          "~/Content/lib/nivo-slider/css/nivo-slider.css",
                          "~/Content/lib/owlcarousel/owl.carousel.css",
                          "~/Content/lib/owlcarousel/owl.transitions.css",
                          "~/Content/lib/font-awesome/css/font-awesome.min.css",
                          "~/Content/lib/animate/animate.min.css",
                          "~/Content/lib/venobox/venobox.css",
                          "~/Content/css/nivo-slider-theme.css",
                          "~/Content/css/style.css",
                          "~/content/css/responsive.css"
                      ));
        }
    }
}
