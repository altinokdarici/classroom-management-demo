using ClassroomManagement.Api.Services;
using Microsoft.AspNetCore.Mvc;

// Layered Arch

namespace ClassroomManagement.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly IWeatherService weatherService;

    public WeatherForecastController(IWeatherService weatherService)
    {
        this.weatherService = weatherService;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get(int skip = 0,int take = 1)
    {
        var result = weatherService.GetWeatherForecast();

        return result.Skip(skip).Take(take);
    }

    [HttpGet(Name = "GetWeatherForecastByCity")]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<WeatherForecast>))]
    public IActionResult GetByCity(string city)
    {
        var result = weatherService.GetWeatherForecastByCity(city);
        if (result == null)
        {
            return NotFound();
        }

        return Ok(result);
    }
}