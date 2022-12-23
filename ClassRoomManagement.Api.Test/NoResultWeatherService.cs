using ClassroomManagement.Api;
using ClassroomManagement.Api.Services;

namespace ClassRoomManagement.Api.Test;

class NoResultWeatherService : IWeatherService
{
    public WeatherForecast[] GetWeatherForecast()
    {
        throw new NotImplementedException();
    }

    public WeatherForecast[] GetWeatherForecastByCity(string city)
    {
        return null;
    }
}
