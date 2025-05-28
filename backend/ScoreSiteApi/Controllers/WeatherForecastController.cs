using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ScoreSiteApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new[] { "Sunny", "Cloudy", "Rainy" };
        }
    }
}
