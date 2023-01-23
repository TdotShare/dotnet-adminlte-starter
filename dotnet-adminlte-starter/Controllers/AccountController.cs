using dotnet_adminlte_starter.Mapper.Templates;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_adminlte_starter.Controllers
{
    public class AccountController : Controller
    {

        private Breadcrumb[] breadcrumb_list = new Breadcrumb[] { new Breadcrumb { Name = "ผู้ใช้งาน", Url = "" } };

        [HttpGet("/account", Name = "account_index_page")]
        public ActionResult Index()
        {
            ViewData["titleheader_data"] = new TitleHeader { Name = "ผู้ใช้งาน", Breadcrumbs = breadcrumb_list };
            return View();
        }

        public ActionResult Create()
        {
            ViewData["titleheader_data"] = new TitleHeader { Name = "ผู้ใช้งาน", Breadcrumbs = breadcrumb_list };
            return View();
        }
    }
}
