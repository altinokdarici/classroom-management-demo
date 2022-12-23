using ClassroomManagement.Api;
using ClassroomManagement.Api.Services;

namespace ClassRoomManagement.Api.Test;

class MockWeatherService : IWeatherService
{
    public WeatherForecast[] GetWeatherForecast()
    {
        return new WeatherForecast[]
        {
           new WeatherForecast
           {
               Date=DateOnly.FromDateTime(DateTime.Now),
               Summary="Sum",
               TemperatureC=1,
               City="TestCity"
           },
           new WeatherForecast
           {
               Date=DateOnly.FromDateTime(DateTime.Now),
               Summary="Sum2",
               TemperatureC=2,
               City="TestCity2"
           }
        };
    }

    public WeatherForecast[] GetWeatherForecastByCity(string city)
    {
        return new WeatherForecast[]
        {
           new WeatherForecast
           {
               Date=DateOnly.FromDateTime(DateTime.Now),
               Summary="Sum",
               TemperatureC=1,
               City=city
           },
           new WeatherForecast
           {
               Date=DateOnly.FromDateTime(DateTime.Now),
               Summary="Sum2",
               TemperatureC=2,
               City=city    
           }
        };
    }
}
