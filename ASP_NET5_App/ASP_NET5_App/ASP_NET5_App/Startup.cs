using ASP_NET5_App.Middlewares;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_NET5_App
{
    public class Startup
    {
    
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment() || env.IsStaging())
            {
                app.UseDeveloperExceptionPage();
            }
            
            app.UseStaticFiles();
            // processing HTTP errors
            app.UseStatusCodePages();

            app.UseRouting();           

            // connect the logic using the middleware layer software
            app.UseMiddleware<LoggingMidlleware>();

            //Console.WriteLine($"Launching project from: {env.ContentRootPath}");

            // route for root page
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync($"Welcome to the {env.ApplicationName}!");
                });
            });

            // routing 
            app.Map("/config", builder => Config(builder, env));
            app.Map("/about", builder => About(builder, env));

            // if route not found
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync($"Page not found");
            });

        }

        /// <summary>
        ///  About page handler
        /// </summary>
        private static void About(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync($"{env.ApplicationName} - ASP.Net Core tutorial project");
            });
        }

        /// <summary>
        ///  Config page handler
        /// </summary>
        private static void Config(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync($"App name: {env.ApplicationName}. App running configuration: {env.EnvironmentName}");
            });
        }
    }
}
