using System;
using ClassroomManagement.Api.Data;

namespace ClassroomManagement.Api.Services
{
    public class WeatherService: IWeatherService
	{
        private readonly ISummariesContext summariesContext;
        public WeatherService(ISummariesContext summariesContext)
        {
            this.summariesContext = summariesContext;
        }

		public WeatherForecast[] GetWeatherForecast()
		{
            var summaries = summariesContext.GetSummaries();

            return Enumerable.Range(1, 6).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = summaries[Random.Shared.Next(summaries.Length)],
                City    = index % 2==0 ? "Istanbul":"Ankara",
            }).ToArray();
        }

        public WeatherForecast[] GetWeatherForecastByCity(string city)
        {
            return this.GetWeatherForecast().Where(x => x.City == city).ToArray();
        }
    }
}

