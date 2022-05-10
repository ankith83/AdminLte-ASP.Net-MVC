using System.Web;
using System.Web.Optimization;

namespace MyShopWeb
{
	public class BundleConfig
	{
		// For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
						"~/Content/jquery/jquery.js"));

			bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
						"~/Content/jquery/jquery.validate*"));

			bundles.Add(new ScriptBundle("~/bundles/adminlte").Include(
					  "~/Content/jquery/adminlte.js"));

			bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
					  "~/Content/jquery/bootstrap.js"));

			bundles.Add(new ScriptBundle("~/bundles/chartsjs").Include(
					  "~/Content/plugins/charts/Chart.js",
					  "~/Content/jquery/dashboard3.js"));

			bundles.Add(new StyleBundle("~/Content/admincss").Include(
					  "~/Content/adminlte.css",
					  "~/Content/site.css",
					  "~/Content/plugins/fontawesome-free/css/all.css"));

			bundles.Add(new StyleBundle("~/Content/charts").Include(
					  "~/Content/plugins/charts/Chart.css"));


		}
	}
}
