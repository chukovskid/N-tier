using N_tier.Core.Models;
using System.Collections.Generic;
using System.Runtime.Caching;

namespace N_tier.DataAccess.InMemory
{
    public class ProductRepository
    {
        ObjectCache cache = MemoryCache.Default;
        List<Product> products;

    }
}
