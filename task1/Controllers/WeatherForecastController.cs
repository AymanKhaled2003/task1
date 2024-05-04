using Microsoft.AspNetCore.Mvc;
using task1.Dtos;
using task1.StrategyPattern;

namespace task1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        private readonly IStrategy _strategy;


        public WeatherForecastController(IStrategy strategy)
        {
            _strategy = strategy;
        }


        [HttpGet(Name = "GetNumber")]
        public IActionResult GetCal([FromQuery]OperationDto operationDto)
        {
            var type = _strategy.CreateCase(operationDto.Types);
            var number= type.Excute(operationDto.x, operationDto.y);
            return Ok(number);
        }
    }
}
