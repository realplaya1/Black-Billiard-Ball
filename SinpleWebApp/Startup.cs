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

namespace SinpleWebApp
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
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    string page = File.ReadAllText("site/homepage.html");
                    await context.Response.WriteAsync(page);
                });

                endpoints.MapGet("/password", async context =>
                {
                    string password = "letmein";
                    await context.Response.WriteAsync(password);
                });

                endpoints.MapGet("/answerpage", async context =>
                {
                    string page = File.ReadAllText("site/answerpage.html");
                    await context.Response.WriteAsync(page);
                });

                endpoints.MapGet("/predictionspage", async context =>
                {
                    string page = File.ReadAllText("site/predictionspage.html");
                    await context.Response.WriteAsync(page);
                });

                endpoints.MapGet("/adminpage", async context =>
                {
                    string page = File.ReadAllText("site/adminpage.html");
                    await context.Response.WriteAsync(page);
                });

                endpoints.MapGet("/randomPrediction", async context =>
                {
                    PredictionManager pm = new PredictionManager();
                    var s = pm.GetRandomPrediction();
                    await context.Response.WriteAsync(s);

                });
            });
        }
    }
}
