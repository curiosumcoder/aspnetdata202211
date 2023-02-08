using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Northwind.Data;
using Northwind.Model;
using Northwind.UI.Internet.ViewModels;
using System.Net.NetworkInformation;
using Northwind.UI.Internet.Extensions;
using System.Collections.Generic;

namespace Northwind.UI.Internet.Controllers
{
    public class CartController : Controller
    {
        private readonly NWContext _db;

        public CartController(NWContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var welcome = HttpContext.Session.GetString("welcome") ?? "";
            ViewBag.welcome = welcome;

            var model = HttpContext.Session.GetObject<List<Product>>("products");
            var viewModel = new CartViewModel();
            viewModel.Items = model ?? new List<Product>();

            //ViewBag.productsAdded = TempData[nameof(Product.ProductName)];
            //TempData.Keep();
            //TempData.Keep(nameof(Product.ProductName));
            //ViewBag.productsAdded = TempData.Peek(nameof(Product.ProductName));

            return View(viewModel);
        }


        [HttpGet]
        public IActionResult Add(int id)
        {
            List<Product> model = new List<Product>();

            if (id > 0)
            {
                model = HttpContext.Session.GetObject<List<Product>>("products") ?? new List<Product>();

                var product = _db.Products.SingleOrDefault(pr => pr.ProductId == id);
                if (product != null)
                {
                    model.Add(product);

                    TempData[nameof(Product.ProductName)] = product.ProductName;
                }

                HttpContext.Session.SetObject<List<Product>>("products", model);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Add(List<CartAddViewModel> products)
        {
            var added = products.Where(p => p.Add).ToList();

            //ViewBag.Products = added;

            List<Product> model = new List<Product>();

            if (added.Count > 0)
            {
                model = HttpContext.Session.GetObject<List<Product>>("products") ?? new List<Product>();

                foreach (var p in added)
                {
                    var product = _db.Products.SingleOrDefault(pr => pr.ProductId == p.ProductId);
                    if (product != null)
                    {
                        model.Add(product);

                        TempData[nameof(Product.ProductName)] += product.ProductName + ", ";
                    }
                }

                HttpContext.Session.SetObject<List<Product>>("products", model);

                //TempData[nameof(Product.ProductName)] =
                //    model.Aggregate("", (a, c) => $"{a},{c.ProductName}");
            }

            //return View("Index", model);
            return RedirectToAction("Index");
        }
    }
}
