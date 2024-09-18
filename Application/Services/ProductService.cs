using Application.Enums;
using Application.Repositories;
using Application.ViewModels;

namespace Application.Services
{
    public class ProductService
    {
        public void AddProduct(CreateProductViewModel cpvm)
        {
            switch (cpvm.Category)
            {
                case (int)ProductType.FRUITS: // Fruits
                    ProductRepository.Instance.Products.Fruits.Add(new ProductViewModel
                    {
                        Name = cpvm.Name,
                        Description = cpvm.Description,
                        Price = cpvm.Price
                    });
                    break;
                case (int)ProductType.VEGETABLES: // Vegetables
                    ProductRepository.Instance.Products.Vegetables.Add(new ProductViewModel
                    {
                        Name = cpvm.Name,
                        Description = cpvm.Description,
                        Price = cpvm.Price
                    });
                    break;
                case (int)ProductType.DAIRY: // Dairy
                    ProductRepository.Instance.Products.Dairy.Add(new ProductViewModel
                    {
                        Name = cpvm.Name,
                        Description = cpvm.Description,
                        Price = cpvm.Price
                    });
                    break;
                default:
                    throw new ArgumentException("Parámetro Inválido");
            }
        }

        public ProductListViewModel GetProducts()
        {
            return ProductRepository.Instance.Products;
        }
    }
}
