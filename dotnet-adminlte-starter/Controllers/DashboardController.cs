using dotnet_adminlte_starter.Mapper.Templates;
using dotnet_adminlte_starter.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace dotnet_adminlte_starter.Controllers
{
    public class DashboardController : Controller
    {
        private Breadcrumb[] breadcrumb_list = new Breadcrumb[] { new Breadcrumb { Name = "แดชบอร์ด", Url = "" } };


        [HttpGet("/dashboard", Name = "dashboard_index_page")]
        public IActionResult Index()
        {
            ViewData["titleheader_data"] = new TitleHeader { Name = "แดชบอร์ด", Breadcrumbs = breadcrumb_list };
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
