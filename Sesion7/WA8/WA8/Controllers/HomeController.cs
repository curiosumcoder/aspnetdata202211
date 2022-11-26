using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WA8.Data;
using WA8.Models;
using WA8.ViewModels;

namespace WA8.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly NWContext _db;

        public HomeController(ILogger<HomeController> logger, NWContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index(HomeIndexViewModel vm)
        {
            //var data = new List<Product>();
            //using (var db = new NWContext())
            //{
            //    data = db.Products.ToList();
            //}

            //return View(_db.Products.ToList());

            if (!string.IsNullOrEmpty(vm.Filter))
            {
                vm.Products = _db.Products.Where(p => p.ProductName.Contains(vm.Filter)).ToList();
            }

            return View(vm);
        }

        public IActionResult Privacy()
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