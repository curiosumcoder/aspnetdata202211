using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Northwind.Data;
using Northwind.UI.Internet.Models;
using Northwind.UI.Internet.ViewModels;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Linq.Dynamic.Core;

namespace Northwind.UI.Internet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly NWContext _db;
        private IMemoryCache _cache;

        public HomeController(ILogger<HomeController> logger, NWContext db, IMemoryCache memoryCache)
        {
            _logger = logger;
            _db = db;
            _cache = memoryCache;
        }

        public IActionResult Index(HomeIndexViewModel vm)
        {
            //_cache.Get("");
            //_cache.Set("", null);
            var offer = _cache.GetOrCreate("offer", entry => {

                var id = new Random().Next(1, _db.Products.Max(p => p.ProductId));
                var productOffer = _db.Products.SingleOrDefault(p=>p.ProductId == id);

                entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(10);

                return productOffer;
            });

            ViewBag.offer = offer;

            HttpContext.Session.SetString("welcome", $"Welcome to our app! {DateTime.Now}");

            if (!string.IsNullOrEmpty(vm.Filter))
            {
                var q1 = _db.Products.Include(p => p.Category).Include(p => p.Supplier).
                    Where(p => p.ProductName.Contains(vm.Filter)).OrderBy(vm.Order);

                vm.FilterResults = q1.Count();

                vm.Products = q1.Skip((vm.Page-1)*10).Take(10).ToList();
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
            var requestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            var exceptionMessage = "";

            var feature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();

            if (feature?.Error is ApplicationException)
            {
                var ex = feature?.Error;

                exceptionMessage = $"Error en la aplicación: {ex?.Message}";
                _logger.LogError(exceptionMessage);
            }
            else if (feature?.Error is Microsoft.Data.SqlClient.SqlException)
            {
                var ex = feature?.Error;
                exceptionMessage = $"Error en el SQL Server: {ex?.Message}";
                _logger.LogError(exceptionMessage);
            }

            if (feature?.Path == "/")
            {
                exceptionMessage += " desde la raíz.";
            }

            return View("Error", new ErrorViewModel { RequestId = requestId });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult ErrorStatus(int code)
        {
            var statusCodeReExecuteFeature = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();

            if (statusCodeReExecuteFeature != null)
            {
                _ =
                    statusCodeReExecuteFeature.OriginalPathBase
                    + statusCodeReExecuteFeature.OriginalPath
                    + statusCodeReExecuteFeature.OriginalQueryString;
            }

            ViewBag.code = code;

            return View();
        }
    }
}