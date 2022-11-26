using WA8.Models;

namespace WA8.ViewModels
{
    public class HomeIndexViewModel
    {
        public string Filter { get; set; } = "";
        public IList<Product> Products { get; set; } = new List<Product>();
    }
}
