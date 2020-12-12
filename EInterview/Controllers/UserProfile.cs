using System.Collections.Generic;

namespace EInterview.Controllers
{
    public class UserProfile
    {
        public IEnumerable<Product> RecentlyViewedProducts { get; set; }
        public IEnumerable<Product> Deals { get; set; }
    }
}
