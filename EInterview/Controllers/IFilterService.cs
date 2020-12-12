using System.Collections.Generic;

namespace EInterview.Controllers
{
    public interface IFilterService
    {
        IEnumerable<Product> Filter(FilterType type, int low, int high);
    }

    public class FilterService : IFilterService
    {
        public IEnumerable<Product> Filter(FilterType type, int low = 1, int high = 500)
        {
            var catlog = DbStorage.GetProductCartlog(1);
            return catlog.Filter(type, low, high);
        }
    }
}