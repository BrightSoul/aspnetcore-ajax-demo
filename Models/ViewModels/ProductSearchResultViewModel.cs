using System.Collections.Generic;

namespace formajax.Models.ViewModels
{
    public class ProductSearchResultViewModel
    {
        public IEnumerable<ProductViewModel> Results { get; set; }
    }
}