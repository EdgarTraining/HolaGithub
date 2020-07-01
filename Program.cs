// Mijail osorio Repo Clone
// El que hace Push Gana.... p
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
<<<<<<< HEAD
// HV modification
=======

// Édgar Sánchez Gordón
>>>>>>> 5675498157ccf74aecf58fdb49c71428468c5311
namespace WebMartes
{
    // Nuevos cambios despues de crear el clon en github
    // Estos cambios *eventualmente* se van a ir al clon
    public class Program // cambio conflictivo en master
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        // otro cambio conflictivo en master
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
