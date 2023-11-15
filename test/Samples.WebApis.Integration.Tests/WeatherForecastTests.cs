using System.Net;
using Microsoft.AspNetCore.Mvc.Testing;

namespace Samples.WebApis.Integration.Tests
{
    public class WeatherForecastTests : IClassFixture<WebApplicationFactoryBase<Program>>
    {
        private readonly HttpClient _client;

        private readonly WebApplicationFactoryBase<Program>
            _factory;

        public WeatherForecastTests(WebApplicationFactoryBase<Program> factory)
        {
            _factory = factory;
            _client = factory.CreateClient(new WebApplicationFactoryClientOptions
            {
                AllowAutoRedirect = false
            });
        }

        [Fact]
        public async Task TestRootEndPoint()
        {
            var defaultPage = await _client.GetAsync("/");
            Assert.NotNull(defaultPage);
            Assert.Equal(HttpStatusCode.NotFound, defaultPage.StatusCode);
        }

        [Fact]
        public async Task TestGetWeatherForecast()
        {
            var defaultPage = await _client.GetAsync("/WeatherForecast");
            Assert.NotNull(defaultPage);
            Assert.Equal(HttpStatusCode.OK, defaultPage.StatusCode);
        }
    }
}