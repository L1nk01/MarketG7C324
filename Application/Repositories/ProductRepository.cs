using Application.ViewModels;

namespace Application.Repositories
{
    public sealed class ProductRepository
    {
        public static ProductRepository Instance { get; } = new();

        public ProductListViewModel Products { get; set; } = new();
    }
}
