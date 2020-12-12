using EInterview.Domain.Entities;
using System.Collections.Generic;

namespace EInterview.Domain.Entities
{
    public class UserProfile
    {
        public IEnumerable<Product> RecentlyViewedProducts { get; set; }
        public IEnumerable<Product> Deals { get; set; }
    }
}
