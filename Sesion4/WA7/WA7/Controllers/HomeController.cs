using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WA7.Data;
using WA7.Models;
using WA7.ViewModels;

namespace WA7.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ProductD _pd;

        public HomeController(ILogger<HomeController> logger, 
            ProductD pd)
        {
            _logger = logger;
            _pd = pd;
        }

        public IActionResult Index(HomeIndexViewModel vm)
        {
            var products = _pd.Get();

            if (!string.IsNullOrEmpty(vm.Filter))
            {
                vm.Products = products.Where(p => p.ProductName.Contains(vm.Filter, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            return View(vm);
        }

        public IActionResult Index3(string filter = "")
        {
            //ViewBag.Filter = filter;
            ViewData["Filter"] = filter;

            var products = _pd.Get();
            var filtered = new List<Product>();

            if (!string.IsNullOrEmpty(filter))
            {
                filtered = products.Where(p => p.ProductName.Contains(filter, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            return View(filtered);
        }

        public IActionResult Index2(string filter="")
        {
            //ViewBag.Filter = filter;
            ViewData["Filter"] = filter;

            var products = _pd.Get();
            var filtered = new List<Product>();

            if (!string.IsNullOrEmpty(filter))
            {
                filtered = products.Where(p => p.ProductName.Contains(filter, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            ViewBag.products = filtered;

            return View();
        }

        public IActionResult Index1(string filter)
        {
            //ViewBag.Filter = filter;
            ViewData["Filter"] = filter;

            var pD = new ProductD();

            ViewBag.products = pD.Get();

            return View();
        }

        public IActionResult Index0()
        {
            //return View("Index0");
            return View();
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