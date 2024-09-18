namespace Application.ViewModels
{
    public class CreateProductViewModel
    {
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public double Price { get; set; }
        public int Category {  get; set; }
    }
}
