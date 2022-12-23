namespace ClassroomManagement.Api.Services
{
    public interface IWeatherService
    {
        WeatherForecast[] GetWeatherForecast();

        WeatherForecast[] GetWeatherForecastByCity(string city);
    }
}

