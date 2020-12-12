using EInterview.Domain.Entities;

namespace EInterview.Dtos
{
    public class FilterRequest
    {
        public FilterType Type { get; set; }
        public int Low { get; set; }
        public int High { get; set; }
        public int CatlogID { get; set; }
    }
}
