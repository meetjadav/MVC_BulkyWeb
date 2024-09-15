using BulkyWeb.Models;

namespace BulkyWeb.ViewModels
{
    public class ProductCategoryViewModel
    {
        public List<Product>? Products { get; set; }
        public List<Category>? Categories { get; set; }

        public Product? Product { get; set; }
    }
}
