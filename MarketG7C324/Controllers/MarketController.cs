using Application.Services;
using Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MarketG7C324.Controllers
{
    public class MarketController : Controller
    {

        private readonly ProductService _productService;

        public MarketController()
        {
            this._productService = new ProductService();
        }

        public IActionResult Index(string? message = null, string? messageType = null)
        {
            ViewBag.Message = message;
            ViewBag.MessageType = messageType;

            return View(_productService.GetProducts());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateProductViewModel cpvm)
        {
            try
            {
                _productService.AddProduct(cpvm);
                return RedirectToRoute(new { controller = "Market", action = "Index", message = "Producto creado satisfactoriamente", messageType ="alert-success" });
            }
            catch (Exception ex) 
            {
                string fullMessage = "Error al crear el producto: " + ex.Message; 
                return RedirectToRoute(new { controller = "Market", action = "Index", message = fullMessage, messageType = "alert-danger" });
            }

        }
    }
}
