using N_tier.Core.Models;
using System.Collections.Generic;

namespace N_tier.Core.ViewModels
{
    public class ProductManagerViewModel
    {
        public Product Product { get; set; }
        public IEnumerable<ProductCategory> ProductCategories { get; set; }

    }
}
