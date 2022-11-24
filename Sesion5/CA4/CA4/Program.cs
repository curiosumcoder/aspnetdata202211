// See https://aka.ms/new-console-template for more information
using CA4.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using System.Linq.Dynamic.Core;

Console.WriteLine("LINQ");

// LINQ to Entities

using (var db = new NorthwindContext())
{
    Console.Clear();
    var n = db.Products.Count();

    Console.WriteLine(n);
    var pageSize = 10;
    var i = 0;
    while (i < n)
    {
        //var q1 = db.Products.Skip(i).Take(pageSize);

        // Eager Loading, Lazy Loading
        var q1 = db.Products.Include(p => p.Category).
            Include(p => p.Supplier).Skip(i).Take(pageSize);

        foreach (var p in q1)
        {
            Console.WriteLine($"{p.ProductName,-40} " +
                $"{p.Category?.CategoryName ?? "Sin Categoría",-15}" +
                $"{p.Supplier?.CompanyName ?? "Sin Proveedor",-40}");
        }

        i += pageSize;
        Console.WriteLine("--------------------------");
        Console.WriteLine($"{i}/{n}");
        Console.ReadKey();
        Console.Clear();
    }

    //var q1 = db.Products.Skip(10);
    //q1 = db.Products.Take(10); // TOP 10

    //Console.WriteLine(q1.Count());
    //foreach (var p in q1)
    //{
    //    Console.WriteLine(p.ProductName);
    //}

    var q0 = from p in db.Products
             select p;
    q0.Skip(5).Take(5);

    var q00 = (from p in db.Products
             select p).Skip(5).Take(5);
}

static void Select()
{
    using (var db = new NorthwindContext())
    {
        //var q1 = from p in db.Products
        //         select p;

        //var q1 = db.Products.Select(p => p); // select *

        //foreach (var p in q1)
        //{
        //    Console.WriteLine(p.ProductName);
        //}

        //var q1 = from p in db.Products
        //         select p.ProductName;

        //var q1 = db.Products.Select(p => p.ProductName);

        //foreach (var p in q1)
        //{
        //    Console.WriteLine(p);
        //}

        //var q1 = from p in db.Products
        //         select new { p.ProductId, p.ProductName };

        //foreach (var p in q1)
        //{
        //    Console.WriteLine($"{p.ProductId} {p.ProductName}");
        //}

        //var q1 = from p in db.Products
        //         select new { Id = p.ProductId, Name = p.ProductName };

        //foreach (var p in q1)
        //{
        //    Console.WriteLine($"{p.Id} {p.Name}");
        //}

        var q1 = from p in db.Products
                 select new ProductDTO { Id = p.ProductId, Name = p.ProductName };

        foreach (var p in q1)
        {
            Console.WriteLine($"{p.Id} {p.Name}");
        }
    }
}

static void Where()
{
    using (var db = new NorthwindContext())
    {
        //var q1 = from p in db.Products
        //         where p.ProductName.Contains("queso") || p.ProductName.Contains("ar")
        //         select p;

        //var q1 = db.Products.Where(p => p.ProductName.Contains("queso") || p.ProductName.Contains("ar"));

        //foreach (var p in q1)
        //{
        //    Console.WriteLine(p.ProductName);
        //}

        //var p1 = db.Products.Find(1);
        //var p1 = db.Products.Where(p => p.ProductId == 100).SingleOrDefault();
        //var p1 = db.Products.SingleOrDefault(p => p.ProductId == 1);

        //if (p1 != null)
        //{
        //    Console.WriteLine(p1.ProductName);
        //}
        //else
        //{
        //    Console.WriteLine("No encontrado.");
        //}

        var products = db.Products.Where(p => p.ProductName.Contains("queso")).ToList();

        var p1 = products.First();
        var p11 = products.FirstOrDefault();
        var p12 = products.FirstOrDefault(p => p.ProductId == 1);
        var p13 = products.Last();
        var p14 = products.Count();
        var p15 = products.Count(p => p.UnitPrice == 200);
        var p16 = products.Sum(p => p.UnitPrice);
        var p17 = products.Average(p => p.UnitPrice);
        var p18 = products.Min(p => p.UnitPrice);
        var p19 = products.Max(p => p.UnitPrice);

        var q1 = from p in db.Products
                 where p.ProductName.Contains("queso") || p.ProductName.Contains("ar")
                 select p;
        q1.Sum(p => p.UnitPrice);

        var sum = (from p in db.Products
                   where p.ProductName.Contains("queso") || p.ProductName.Contains("ar")
                   select p).Sum(p => p.UnitPrice);
    }
}

static void OrderBy()
{
    using (var db = new NorthwindContext())
    {
        //var q1 = from p in db.Products
        //         where p.UnitPrice > 10 && p.ProductName.Contains("ar")
        //         orderby p.ProductName descending, p.UnitPrice
        //         select p;

        //var q1 = db.Products.Where(p => p.UnitPrice > 10 && p.ProductName.Contains("ar")).OrderByDescending(p => p.ProductName).ThenBy(p => p.UnitPrice);

        var order = "ProductName DESC, UnitPrice";
        var q1 = db.Products.Where(p => p.UnitPrice > 10 && p.ProductName.Contains("ar")).OrderBy(order);

        foreach (var p in q1)
        {
            Console.WriteLine($"{p.ProductName}, {p.UnitPrice}");
        }
    }
}

class ProductDTO
{
    public int Id { get; set; } = 0;
    public string Name { get; set; } = "";
}