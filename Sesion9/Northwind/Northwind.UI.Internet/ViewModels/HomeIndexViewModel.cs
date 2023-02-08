using Northwind.Model;
using Northwind.UI.Internet.Models;

namespace Northwind.UI.Internet.ViewModels
{
    public class HomeIndexViewModel
    {
        public string Filter { get; set; } = "";
        public int FilterResults { get; set; }
        public IList<Product> Products { get; set; } = new List<Product>();

        /// <summary>
        /// Número de página
        /// </summary>
        public int Page { get; set; } = 1;
        public string Order { get; set; } = "ProductName";
    }
}
