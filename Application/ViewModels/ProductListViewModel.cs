namespace Application.ViewModels
{
    public class ProductListViewModel
    {
        public List<ProductViewModel> Fruits { get; set; } = new();
        public List<ProductViewModel> Vegetables { get; set; } = new();
        public List<ProductViewModel> Dairy { get; set; } = new();
    }
}