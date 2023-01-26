using dotnet_adminlte_starter.Mapper.Templates;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_adminlte_starter.ViewComponents
{
    [ViewComponent(Name = "MenuList")]
    public class MenuViewComponent : ViewComponent
    {

        public IViewComponentResult Invoke()
        {

            string[] paths = $"{Request.Path}".ToLower().Split('/');

            var sidebar_data = new Sidebar[]
            {
                new Sidebar{ Name = "แดชบอร์ด" , Url = "dashboard_index_page", Icon = "fas fa-th" , Path = paths.Contains("dashboard") ? "active" : "" },
                new Sidebar{ Name = "ผู้ใช้งาน" , Url = "account_index_page", Icon = "fas fa-users" , Path = paths.Contains("account") ? "active" : "" },
            };

            ViewData["sidebar_data"] = sidebar_data;

            return View("_Sidebar");
        }
    }
}
