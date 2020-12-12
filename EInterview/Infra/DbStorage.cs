using EInterview.Controllers;
using EInterview.Domain.Entities;
using System.Collections;
using System.Collections.Generic;

namespace EInterview.Infra
{
    public class DbStorage
    {
        private static UserProfile profile = new UserProfile()
        {
            RecentlyViewedProducts = new List<Product>
            {
                new Product { Price = 500 },
                new Product { Price = 100 }
            }
        };

        private static ProductCartlog cartlog = new ProductCartlog
        {
            Products = new List<Product>
            {
                new Product { Price = 500 },
                new Product { Price = 100 }
            }
        };

        public static UserProfile GetProfile(int id) => profile;
        public static ProductCartlog GetProductCartlog(int id) => cartlog;

    }
}