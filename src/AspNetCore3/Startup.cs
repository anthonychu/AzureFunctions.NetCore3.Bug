using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetCore3
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services) => services.AddControllers();

        public void Configure(IApplicationBuilder app, IWebHostEnvironment environment) =>
            app.UseHttpsRedirection()
                .UseRouting()
                .UseEndpoints(endpoints =>
                {
                    endpoints.MapControllers();
                });
    }
}
