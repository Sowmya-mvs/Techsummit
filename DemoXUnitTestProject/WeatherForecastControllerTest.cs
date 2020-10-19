using DemoDotNetCoreApp.Controllers;
using System.Linq;
using Xunit;

namespace DemoXUnitTestProject
{
    public class WeatherForecastControllerTest
    {
        WeatherForecastController _weatherForecastController;

        public WeatherForecastControllerTest()
        {
            _weatherForecastController = new WeatherForecastController();
        }

        [Fact]
        public void Get_WhenCalled_ReturnsWeatherForecastObjectList()
        {
            //Act
            var actualResult = _weatherForecastController.Get();

            //Assert
            Assert.Equal(5, actualResult.Count());
        }
    }
}
