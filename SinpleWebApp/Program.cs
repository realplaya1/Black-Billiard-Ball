using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinpleWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var hostBuilder = CreateHostBuilder(args); //  |
            var host = hostBuilder.Build();            //  |   CreateHostBuilder(args).Build().Run();
            host.Run();                                //  |

            
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
           


            var hostBuilder = Host.CreateDefaultBuilder(args);  //  |    return Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder =>
            hostBuilder.ConfigureWebHostDefaults(webBuilder =>  //  |    {
            {                                                   //  |        webBuilder.UseStartup<Startup>();
                webBuilder.UseStartup<Startup>();               //  |    }); 
            });

            return hostBuilder;
        }
    }
}
