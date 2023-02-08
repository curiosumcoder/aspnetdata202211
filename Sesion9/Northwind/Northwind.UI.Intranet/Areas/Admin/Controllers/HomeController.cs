using Microsoft.AspNetCore.Mvc;

namespace Northwind.UI.Intranet.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
