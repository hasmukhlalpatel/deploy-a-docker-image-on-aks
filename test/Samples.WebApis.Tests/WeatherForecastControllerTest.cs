using Microsoft.Extensions.Logging.Abstractions;
using Samples.WebApis.Controllers;
using Shouldly;

namespace Samples.WebApis.Tests
{
    public class WeatherForecastControllerTest
    {
        private readonly WeatherForecastController _controller;
        public WeatherForecastControllerTest()
        {
            _controller = new WeatherForecastController( new NullLogger<WeatherForecastController>());
        }

        [Fact]
        public void Test1()
        {
            var results= _controller.Get();
            Assert.NotNull(results);
            results.ShouldNotBeNull();

        }
    }
}