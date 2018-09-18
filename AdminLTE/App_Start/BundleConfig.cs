using System.Web.Optimization;

namespace AdminLTE
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            RegisterLayout(bundles);
        }
        private static void RegisterLayout(BundleCollection bundles)
        {
            //bootstrap
            bundles.Add(new StyleBundle("~/bootstrap/css").Include(
                "~/AdminLTE/bower_components/bootstrap/dist/css/bootstrap.min.css"));            
            bundles.Add(new ScriptBundle("~/bootstrap/js").Include(
                "~/AdminLTE/bower_components/bootstrap/dist/js/bootstrap.min.js"));

            //bootstrap-datepicker
            bundles.Add(new StyleBundle("~/bootstrap-datepicker/css").Include(
                "~/AdminLTE/bower_components/bootstrap-datepicker/dist/css/bootstrap.min.css"));
            bundles.Add(new ScriptBundle("~/bootstrap-datepicker/js").Include(
                "~/AdminLTE/bower_components/bootstrap-datepicker/dist/js/bootstrap.min.js"));

            //bootstrap-daterangepicker
            bundles.Add(new StyleBundle("~/bootstrap-daterangepicker/css").Include(
                "~/AdminLTE/bower_components/bootstrap-daterangepicker/daterangepicker.css"));
            bundles.Add(new ScriptBundle("~/bootstrap-daterangepicker/js").Include(
                "~/AdminLTE/bower_components/bootstrap-daterangepicker/daterangepicker.js"));

            //bootstrap-wysihtml5
            bundles.Add(new StyleBundle("~/bootstrap-wysihtml5/css").Include(
                "~/AdminLTE/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.css"));
            bundles.Add(new ScriptBundle("~/bootstrap-wysihtml5/js").Include(
                "~/AdminLTE/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.all.js"));

            //adminlte
            bundles.Add(new StyleBundle("~/adminlte/css").Include(
                "~/AdminLTE/dist/css/AdminLTE.min.css"));
            bundles.Add(new ScriptBundle("~/adminlte/js").Include(
                "~/AdminLTE/dist/js/adminlte.min.js"));
            bundles.Add(new StyleBundle("~/adminlte/skins/css").Include(
                "~/AdminLTE/dist/css/skins/_all-skins.min.css"));

            //font-awesome
            bundles.Add(new StyleBundle("~/font-awesome/css").Include(
                "~/AdminLTE/bower_components/font-awesome/css/font-awesome.min.css"));

            //ionicons
            bundles.Add(new StyleBundle("~/ionicons/css").Include(
                "~/AdminLTE/bower_components/Ionicons/css/ionicons.min.css"));


            //jquery
            bundles.Add(new ScriptBundle("~/jquery/js").Include(
                "~/AdminLTE/bower_components/jquery/dist/jquery.min.js"));

            //jquery-ui
            bundles.Add(new ScriptBundle("~/jquery-ui/js").Include(
                                        "~/AdminLTE/plugins/jqueryui/jquery-ui.js"));

            //jquery-jvectormap
            bundles.Add(new StyleBundle("~/jquery-jvectormap/css").Include(
                                        "~/AdminLTE/bower_components/jvectormap/jvectormap.css"));
            bundles.Add(new ScriptBundle("~/jquery-jvectormap/js").Include(
                                        "~/AdminLTE/plugins/jvectormap/jquery-jvectormap-1.2.2.min.js"));
            bundles.Add(new ScriptBundle("~/jquery-jvectormap-world-mill-en/js").Include(
                                        "~/AdminLTE/plugins/jvectormap/jquery-jvectormap-world-mill-en.js"));
            //jquery-jvectormap-world-mill-en

            //jquery-sparkline
            bundles.Add(new ScriptBundle("~/jquery-sparkline/js").Include(
                                        "~/AdminLTE/bower_components/jquery-sparkline/dist/jquery.sparkline.js"));

            //jquery-knob
            bundles.Add(new ScriptBundle("~/jquery-knob/js").Include(
                                        "~/AdminLTE/bower_components/jquery-knob/dist/jquery.knob.min.js"));

            //jquery-slimscroll
            bundles.Add(new ScriptBundle("~/jquery-slimscroll/js").Include(
                                        "~/AdminLTE/bower_components/jquery-slimscroll/jquery.slimscroll.min.js"));
            //jquery-cookie
            bundles.Add(new ScriptBundle("~/jquery-cookie/js").Include(
                                        "~/Content/js/cookie/jquery.cookie.js"));

            //jquery-md5
            bundles.Add(new ScriptBundle("~/jquery-md5/js").Include(
                                        "~/Content/js/md5/jquery.md5.js"));

            //raphael
            bundles.Add(new ScriptBundle("~/raphael/js").Include(
                                        "~/AdminLTE/bower_components/raphael/raphael.js"));

            //morris
            bundles.Add(new StyleBundle("~/morris/css").Include(
                                        "~/AdminLTE/bower_components/morris.js/morris.css"));
            bundles.Add(new ScriptBundle("~/morris/js").Include(
                                        "~/AdminLTE/bower_components/morris.js/morris.js"));

            //moment
            bundles.Add(new ScriptBundle("~/moment/js").Include(
                                        "~/AdminLTE/bower_components/moment/moment.js"));

            //fastclick
            bundles.Add(new ScriptBundle("~/fastclick/js").Include(
                                        "~/AdminLTE/bower_components/fastclick/lib/fastclick.js"));
            //icheck
            bundles.Add(new StyleBundle("~/icheck/css/sqare/blue").Include(
                                        "~/AdminLTE/plugins/icheck/square/blue.css"));
            bundles.Add(new ScriptBundle("~/icheck/js").Include(
                                         "~/AdminLTE/plugins/icheck/icheck.min.js"));

            //dashboard
            bundles.Add(new ScriptBundle("~/dashboard/js").Include(
                                        "~/AdminLTE/dist/js/pages/dashboard.js"));

            //demo
            bundles.Add(new ScriptBundle("~/demo/js").Include(
                                        "~/AdminLTE/dist/js/demo.js"));
        }
    }
}