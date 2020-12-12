using System.Collections.Generic;
using System.Linq;

namespace EInterview.Domain.Entities
{
    public class ProductCartlog
    {
        public IEnumerable<Product> Products { get; set; }

        public void Filter()
        {

        }

        public IEnumerable<Product> Filter(FilterType filterType = FilterType.LowToHigh, int low = 1, int high = 500)
        {
            return filterType switch
            {
                FilterType.LowToHigh => Products.OrderBy(x => x.Price),
                FilterType.HighToLow => Products.OrderByDescending(x => x.Price),
                FilterType.Range => Products.Where(p => p.Price >= low && p.Price <= high),
            };
        }
    }
}
