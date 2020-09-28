using N_tier.Core.Models;
using N_tier.DataAccess.SQL;
using System.Collections.Generic;

namespace N_tier.Application.ProductExpiration
{
    public class ProductExpirationTime : IProductExpirationTime
    {
        DataContext _context;
        public ProductExpirationTime(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetTimeLeft()
        {
            var products = _context.Products;

            foreach (var product in products)
            {
                // some Logic for Expiration Date
            }

            var listOfExpiredProducts = new List<Product>();

            return listOfExpiredProducts;


        }


    }
}
