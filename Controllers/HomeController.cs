using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using formajax.Models.Services.Application;
using formajax.Models.ViewModels;

namespace formajax.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Search(ProductSearchInputModel inputModel, [FromServices] IProductService productService)
        {
            var result = new ProductSearchResultViewModel
            {
                Results = productService.Search(inputModel)
            }; 
            return View("ProductSearchResults", result);
        }
    }
}
