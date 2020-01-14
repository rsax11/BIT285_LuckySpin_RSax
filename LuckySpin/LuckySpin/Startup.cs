using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;


namespace LuckySpin
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<Lucky7>();
        }

       public void Configure(IApplicationBuilder app, IHostingEnvironment env, Lucky7 Lucky7)
        {
            app.Run(async (context) =>
            {
            await context.Response.WriteAsync(Lucky7.Output());
            });

        }
    }
}