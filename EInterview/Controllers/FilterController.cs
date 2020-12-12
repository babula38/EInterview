using EInterview.Dtos;
using EInterview.Services;
using Microsoft.AspNetCore.Mvc;

namespace EInterview.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilterController : ControllerBase
    {
        public FilterController(IFilterService filterservice)
        {
            _filterservice = filterservice;
        }

        private IFilterService _filterservice { get; }

        [HttpPost]
        public IActionResult Post(FilterRequest request)
        {
            return Ok(_filterservice.Filter(request.Type, request.Low, request.High));
        }

    }
}
