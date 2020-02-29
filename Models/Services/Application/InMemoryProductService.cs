using System;
using System.Collections.Generic;
using System.Linq;
using formajax.Models.ViewModels;

namespace formajax.Models.Services.Application
{
    public class InMemoryProductService : IProductService
    {
        public IEnumerable<ProductViewModel> Search(ProductSearchInputModel inputModel)
        {
            IEnumerable<ProductViewModel> results = products;
            //Filtro per categoria, se è stata indicata
            if (!string.IsNullOrEmpty(inputModel.Category))
            {
                results = results.Where(p => p.Category == inputModel.Category);
            }
            //Filtro per parola, se è stata indicata
            if (!string.IsNullOrEmpty(inputModel.Search))
            {
                results = results.Where(p => p.Description.Contains(inputModel.Search, StringComparison.InvariantCultureIgnoreCase));
            }
            return results;
        }

        //TODO: Questi dati devono arrivare dal database, ad esempio forniti da un servizio infrastrutturale
        private static ProductViewModel[] products = new [] {
            new ProductViewModel { Id = 1, Description = "Melanzana", Category = "Verdura" },
            new ProductViewModel { Id = 2, Description = "Zucchina", Category = "Verdura" },
            new ProductViewModel { Id = 3, Description = "Carota", Category = "Verdura" },
            new ProductViewModel { Id = 4, Description = "Radicchio", Category = "Verdura" },
            new ProductViewModel { Id = 5, Description = "Spinaci", Category = "Verdura" },
            new ProductViewModel { Id = 6, Description = "Broccolo", Category = "Verdura" },
            new ProductViewModel { Id = 7, Description = "Pesca", Category = "Frutta" },
            new ProductViewModel { Id = 8, Description = "Fragola", Category = "Frutta" },
            new ProductViewModel { Id = 9, Description = "Mela", Category = "Frutta" },
            new ProductViewModel { Id = 10, Description = "Pera", Category = "Frutta" }
        };
    }
}