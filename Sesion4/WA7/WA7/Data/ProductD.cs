using WA7.Models;

namespace WA7.Data
{
    public class ProductD
    {
        /// <summary>
        /// Obtiene la lista completa de products.
        /// </summary>
        /// <returns>Lista de productos.</returns>
        public List<Product> Get()
        {
            return new List<Product>() {
                new Product { ProductId = 1, ProductName = "Chai", QuantityPerUnit = "10 boxes x 20 bags", UnitPrice = 10.00m },
                new Product { ProductId = 2, ProductName = "Chang", QuantityPerUnit = "24 - 12 oz bottles", UnitPrice = 19.00m },
                new Product { ProductId = 3, ProductName = "Aniseed Syrup", QuantityPerUnit = "12 - 550 ml bottles", UnitPrice = 10.00m },
                new Product { ProductId = 4, ProductName = "Chef Anton's Cajun Seasoning", QuantityPerUnit = "48 - 6 oz jars", UnitPrice = 22.00m },
                new Product { ProductId = 5, ProductName = "Chef Anton's Gumbo Mix", QuantityPerUnit = "36 boxes", UnitPrice = 21.35m },
                new Product { ProductId = 6, ProductName = "Grandma's Boysenberry Spread", QuantityPerUnit = "12 - 8 oz jars", UnitPrice = 25.00m },
                new Product { ProductId = 7, ProductName = "Uncle Bob's Organic Dried Pears", QuantityPerUnit = "12 - 1 lb pkgs.", UnitPrice = 30.00m },
                new Product { ProductId = 8, ProductName = "Northwoods Cranberry Sauce", QuantityPerUnit = "12 - 12 oz jars", UnitPrice = 40.00m },
                new Product { ProductId = 9, ProductName = "Mishi Kobe Niku", QuantityPerUnit = "18 - 500 g pkgs.", UnitPrice = 97.00m },
                new Product { ProductId = 10, ProductName = "Ikura", QuantityPerUnit = "12 - 200 ml jars", UnitPrice = 31.00m },
                new Product { ProductId = 11, ProductName = "Queso Cabrales", QuantityPerUnit = "1 kg pkg.", UnitPrice = 21.00m },
                new Product { ProductId = 12, ProductName = "Queso Manchego La Pastora", QuantityPerUnit = "10 - 500 g pkgs.", UnitPrice = 38.00m },
                new Product { ProductId = 13, ProductName = "Konbu", QuantityPerUnit = "2 kg box", UnitPrice = 6.00m },
                new Product { ProductId = 14, ProductName = "Tofu", QuantityPerUnit = "40 - 100 g pkgs.", UnitPrice = 23.25m },
                new Product { ProductId = 15, ProductName = "Genen Shouyu", QuantityPerUnit = "24 - 250 ml bottles", UnitPrice = 15.50m },
                new Product { ProductId = 16, ProductName = "Pavlova", QuantityPerUnit = "32 - 500 g boxes", UnitPrice = 17.45m },
                new Product { ProductId = 17, ProductName = "Alice Mutton", QuantityPerUnit = "20 - 1 kg tins", UnitPrice = 39.00m },
                new Product { ProductId = 18, ProductName = "Carnarvon Tigers", QuantityPerUnit = "16 kg pkg.", UnitPrice = 62.50m },
                new Product { ProductId = 19, ProductName = "Teatime Chocolate Biscuits", QuantityPerUnit = "10 boxes x 12 pieces", UnitPrice = 9.20m },
                new Product { ProductId = 20, ProductName = "Sir Rodney's Marmalade", QuantityPerUnit = "30 gift boxes", UnitPrice = 81.00m },
                new Product { ProductId = 21, ProductName = "Sir Rodney's Scones", QuantityPerUnit = "24 pkgs. x 4 pieces", UnitPrice = 10.00m },
                new Product { ProductId = 22, ProductName = "Gustaf's Knäckebröd", QuantityPerUnit = "24 - 500 g pkgs.", UnitPrice = 21.00m },
                new Product { ProductId = 23, ProductName = "Tunnbröd", QuantityPerUnit = "12 - 250 g pkgs.", UnitPrice = 9.00m },
                new Product { ProductId = 24, ProductName = "Guaraná Fantástica", QuantityPerUnit = "12 - 355 ml cans", UnitPrice = 4.50m },
                new Product { ProductId = 25, ProductName = "NuNuCa Nuß-Nougat-Creme", QuantityPerUnit = "20 - 450 g glasses", UnitPrice = 14.00m },
                new Product { ProductId = 26, ProductName = "Gumbär Gummibärchen", QuantityPerUnit = "100 - 250 g bags", UnitPrice = 31.23m },
                new Product { ProductId = 27, ProductName = "Schoggi Schokolade", QuantityPerUnit = "100 - 100 g pieces", UnitPrice = 43.90m },
                new Product { ProductId = 28, ProductName = "Rössle Sauerkraut", QuantityPerUnit = "25 - 825 g cans", UnitPrice = 45.60m },
                new Product { ProductId = 29, ProductName = "Thüringer Rostbratwurst", QuantityPerUnit = "50 bags x 30 sausgs.", UnitPrice = 123.79m },
                new Product { ProductId = 30, ProductName = "Nord-Ost Matjeshering", QuantityPerUnit = "10 - 200 g glasses", UnitPrice = 25.89m },
                new Product { ProductId = 31, ProductName = "Gorgonzola Telino", QuantityPerUnit = "12 - 100 g pkgs", UnitPrice = 12.50m },
                new Product { ProductId = 32, ProductName = "Mascarpone Fabioli", QuantityPerUnit = "24 - 200 g pkgs.", UnitPrice = 32.00m },
                new Product { ProductId = 33, ProductName = "Geitost", QuantityPerUnit = "500 g", UnitPrice = 2.50m },
                new Product { ProductId = 34, ProductName = "Sasquatch Ale", QuantityPerUnit = "24 - 12 oz bottles", UnitPrice = 14.00m },
                new Product { ProductId = 35, ProductName = "Steeleye Stout", QuantityPerUnit = "24 - 12 oz bottles", UnitPrice = 18.00m },
                new Product { ProductId = 36, ProductName = "Inlagd Sill", QuantityPerUnit = "24 - 250 g  jars", UnitPrice = 19.00m },
                new Product { ProductId = 37, ProductName = "Gravad lax", QuantityPerUnit = "12 - 500 g pkgs.", UnitPrice = 26.00m },
                new Product { ProductId = 38, ProductName = "Côte de Blaye", QuantityPerUnit = "12 - 75 cl bottles", UnitPrice = 263.50m },
                new Product { ProductId = 39, ProductName = "Chartreuse verte", QuantityPerUnit = "750 cc per bottle", UnitPrice = 18.00m },
                new Product { ProductId = 40, ProductName = "Boston Crab Meat", QuantityPerUnit = "24 - 4 oz tins", UnitPrice = 18.40m },
                new Product { ProductId = 41, ProductName = "Jack's New England Clam Chowder", QuantityPerUnit = "12 - 12 oz cans", UnitPrice = 9.65m },
                new Product { ProductId = 42, ProductName = "Singaporean Hokkien Fried Mee", QuantityPerUnit = "32 - 1 kg pkgs.", UnitPrice = 14.00m },
                new Product { ProductId = 43, ProductName = "Ipoh Coffee", QuantityPerUnit = "16 - 500 g tins", UnitPrice = 46.00m },
                new Product { ProductId = 44, ProductName = "Gula Malacca", QuantityPerUnit = "20 - 2 kg bags", UnitPrice = 19.45m },
                new Product { ProductId = 45, ProductName = "Rogede sild", QuantityPerUnit = "1k pkg.", UnitPrice = 9.50m },
                new Product { ProductId = 46, ProductName = "Spegesild", QuantityPerUnit = "4 - 450 g glasses", UnitPrice = 12.00m },
                new Product { ProductId = 47, ProductName = "Zaanse koeken", QuantityPerUnit = "10 - 4 oz boxes", UnitPrice = 9.50m },
                new Product { ProductId = 48, ProductName = "Chocolade", QuantityPerUnit = "10 pkgs.", UnitPrice = 12.75m },
                new Product { ProductId = 49, ProductName = "Maxilaku", QuantityPerUnit = "24 - 50 g pkgs.", UnitPrice = 20.00m },
                new Product { ProductId = 50, ProductName = "Valkoinen suklaa", QuantityPerUnit = "12 - 100 g bars", UnitPrice = 16.25m },
                new Product { ProductId = 51, ProductName = "Manjimup Dried Apples", QuantityPerUnit = "50 - 300 g pkgs.", UnitPrice = 53.00m },
                new Product { ProductId = 52, ProductName = "Filo Mix", QuantityPerUnit = "16 - 2 kg boxes", UnitPrice = 7.00m },
                new Product { ProductId = 53, ProductName = "Perth Pasties", QuantityPerUnit = "48 pieces", UnitPrice = 32.80m },
                new Product { ProductId = 54, ProductName = "Tourtière", QuantityPerUnit = "16 pies", UnitPrice = 7.45m },
                new Product { ProductId = 55, ProductName = "Pâté chinois", QuantityPerUnit = "24 boxes x 2 pies", UnitPrice = 24.00m },
                new Product { ProductId = 56, ProductName = "Gnocchi di nonna Alice", QuantityPerUnit = "24 - 250 g pkgs.", UnitPrice = 38.00m },
                new Product { ProductId = 57, ProductName = "Ravioli Angelo", QuantityPerUnit = "24 - 250 g pkgs.", UnitPrice = 19.50m },
                new Product { ProductId = 58, ProductName = "Escargots de Bourgogne", QuantityPerUnit = "24 pieces", UnitPrice = 13.25m },
                new Product { ProductId = 59, ProductName = "Raclette Courdavault", QuantityPerUnit = "5 kg pkg.", UnitPrice = 55.00m },
                new Product { ProductId = 60, ProductName = "Camembert Pierrot", QuantityPerUnit = "15 - 300 g rounds", UnitPrice = 34.00m },
                new Product { ProductId = 61, ProductName = "Sirop d'érable", QuantityPerUnit = "24 - 500 ml bottles", UnitPrice = 28.50m },
                new Product { ProductId = 62, ProductName = "Tarte au sucre", QuantityPerUnit = "48 pies", UnitPrice = 49.30m },
                new Product { ProductId = 63, ProductName = "Vegie-spread", QuantityPerUnit = "15 - 625 g jars", UnitPrice = 43.90m },
                new Product { ProductId = 64, ProductName = "Wimmers gute Semmelknödel", QuantityPerUnit = "20 bags x 4 pieces", UnitPrice = 33.25m },
                new Product { ProductId = 65, ProductName = "Louisiana Fiery Hot Pepper Sauce", QuantityPerUnit = "32 - 8 oz bottles", UnitPrice = 21.05m },
                new Product { ProductId = 66, ProductName = "Louisiana Hot Spiced Okra", QuantityPerUnit = "24 - 8 oz jars", UnitPrice = 17.00m },
                new Product { ProductId = 67, ProductName = "Laughing Lumberjack Lager", QuantityPerUnit = "24 - 12 oz bottles", UnitPrice = 14.00m },
                new Product { ProductId = 68, ProductName = "Scottish Longbreads", QuantityPerUnit = "10 boxes x 8 pieces", UnitPrice = 12.50m },
                new Product { ProductId = 69, ProductName = "Gudbrandsdalsost", QuantityPerUnit = "10 kg pkg.", UnitPrice = 36.00m },
                new Product { ProductId = 70, ProductName = "Outback Lager", QuantityPerUnit = "24 - 355 ml bottles", UnitPrice = 15.00m },
                new Product { ProductId = 71, ProductName = "Flotemysost", QuantityPerUnit = "10 - 500 g pkgs.", UnitPrice = 21.50m },
                new Product { ProductId = 72, ProductName = "Mozzarella di Giovanni", QuantityPerUnit = "24 - 200 g pkgs.", UnitPrice = 34.80m },
                new Product { ProductId = 73, ProductName = "Röd Kaviar", QuantityPerUnit = "24 - 150 g jars", UnitPrice = 15.00m },
                new Product { ProductId = 74, ProductName = "Longlife Tofu", QuantityPerUnit = "5 kg pkg.", UnitPrice = 10.00m },
                new Product { ProductId = 75, ProductName = "Rhönbräu Klosterbier", QuantityPerUnit = "24 - 0.5 l bottles", UnitPrice = 7.75m },
                new Product { ProductId = 76, ProductName = "Lakkalikööri", QuantityPerUnit = "500 ml", UnitPrice = 18.00m },
                new Product { ProductId = 77, ProductName = "Original Frankfurter grüne Soße", QuantityPerUnit = "12 boxes", UnitPrice = 13.00m }
            };
        }
    }
}
