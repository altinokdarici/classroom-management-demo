using System;
using ClassroomManagement.Api.Controllers;
using ClassroomManagement.Api.Services;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace ClassRoomManagement.Api.Test;

[TestClass]
public class ForecastControllerTests
{
    [TestMethod]
    public void GetAllForecast()
    {
        IWeatherService service = new MockWeatherService();

        // Prep
        WeatherForecastController controller = new WeatherForecastController(service);

        // Act
        var result = controller.Get();

        // Assert
        Assert.AreEqual(1, result.Count());
    }

    [TestMethod]
    public void GetForecastByCity()
    {
        IWeatherService service = new MockWeatherService();

        // Prep
        WeatherForecastController controller = new WeatherForecastController(service);

        // Act
        var result = controller.GetByCity("Istanbul");

        var statusCodeResult = (IStatusCodeActionResult)result;

        // Assert
        Assert.AreEqual(200, statusCodeResult.StatusCode);
    }

    [TestMethod]
    public void GetForecastByCityNoResult()
    {
        IWeatherService service = new NoResultWeatherService();

        // Prep
        WeatherForecastController controller = new WeatherForecastController(service);

        // Act
        var result = controller.GetByCity("Istanbul");

        var statusCodeResult = (IStatusCodeActionResult)result;

        // Assert
        Assert.AreEqual(404, statusCodeResult.StatusCode);
    }
}
