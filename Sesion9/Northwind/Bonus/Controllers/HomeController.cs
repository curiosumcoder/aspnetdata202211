using Bonus.Models;
using Microsoft.AspNetCore.Mvc;
using Northwind.Data;
using System.Diagnostics;
using X.PagedList;

namespace Bonus.Controllers
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

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Paginacion(int page = 1)
        {
            return View(_db.Products.ToPagedList(page, 5));
        }

        public IActionResult Tabular()
        {
            return View(_db.Products.ToList());
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