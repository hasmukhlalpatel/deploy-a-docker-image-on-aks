using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;

namespace Samples.WebApis.Integration.Tests;

public class WebApplicationFactoryBase<TProgram> : WebApplicationFactory<TProgram>
    where TProgram : class
{
    /// <summary>
    /// ConfigureWebHost.
    /// </summary>
    /// <param name="builder">IWebHostBuilder parameter.</param>
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
#pragma warning disable CA1062 // Validate arguments of public methods
        builder.ConfigureServices(services =>
        {

        });
#pragma warning restore CA1062 // Validate arguments of public methods

        builder.UseEnvironment("Development");
    }
}