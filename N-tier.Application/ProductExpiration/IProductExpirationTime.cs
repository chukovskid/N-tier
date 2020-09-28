using N_tier.Core.Models;
using System.Collections.Generic;

namespace N_tier.Application.ProductExpiration
{
    public interface IProductExpirationTime
    {
        public IEnumerable<Product> GetTimeLeft();
    }
}
