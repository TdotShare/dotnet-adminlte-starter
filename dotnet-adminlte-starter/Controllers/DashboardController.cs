using dotnet_adminlte_starter.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace dotnet_adminlte_starter.Controllers
{
    public class DashboardController : Controller
    {

        [HttpGet("/dashboard", Name = "dashboard_index_page")]
        public IActionResult Index()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
