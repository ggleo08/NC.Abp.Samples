using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Sample01.Web
{
    public class Startup
    {
        private IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        //public IServiceProvider ConfigureServices(IServiceCollection services)
        //{
        //    services.AddApplication<Sample01WebAppModule>();
        //    return services.BuildServiceProviderFromFactory();
        //}

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<Sample01WebAppModule>();
            //return services.BuildServiceProviderFromFactory();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.InitializeApplication();
        }
    }
}