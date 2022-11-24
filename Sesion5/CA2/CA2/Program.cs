// See https://aka.ms/new-console-template for more information
using CA2.Data;
using CA2.Models;

Console.WriteLine("Hello, World!");

//using (var db = new NorthwindContext())
//{
//	foreach (var p in db.Products)
//	{
//		Console.WriteLine(p.ProductName);
//	}
//}

// CRUD
using (var db = new NorthwindContext())
{
    // ChangeTracking
    // Create
    var p1 = new Product() { ProductName = "Mi Teléfono", UnitPrice = 100 };

    db.Products.Add(p1);
    db.SaveChanges();

    // Read
    var product = db.Products.Find(p1.ProductId);
    //var product = db.Products.Find(100);

    Console.WriteLine(product?.ProductName ?? "No se encontró el producto");

    // Update
    if (product != null)
    {
        product.ProductName += " Modificado";
    }
    db.SaveChanges();

    //db.Remove(p1);
    db.Products.Remove(p1);
    db.SaveChanges();
}