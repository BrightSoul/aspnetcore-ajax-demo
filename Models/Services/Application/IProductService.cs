using System.Collections.Generic;
using System.Linq;
using formajax.Models.ViewModels;

namespace formajax.Models.Services.Application
{
    public interface IProductService
    {
        IEnumerable<ProductViewModel> Search(ProductSearchInputModel inputModel);
    }
}