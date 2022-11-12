using WA7.Models;

namespace WA7.ViewModels
{
    public class HomeIndexViewModel
    {
        public string Filter { get; set; } = "";
        public IEnumerable<Product> Products { get; set; } = new List<Product>();
    }
}
