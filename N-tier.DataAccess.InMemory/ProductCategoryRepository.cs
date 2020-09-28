using N_tier.Core.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Caching;
using System.Text;

namespace N_tier.DataAccess.InMemory
{
    public class ProductCategoryRepository
    {
        ObjectCache cache = MemoryCache.Default;
        List<ProductCategory> productCategories;
    }
}
