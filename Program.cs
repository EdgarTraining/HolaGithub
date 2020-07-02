// Mijail osorio Repo Clone
// El que hace Push Gana.... 
// Modifican en busca de Conflictos
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

//Modified GLL
// HV modification
namespace WebMartes
// Comentar lo mio para evitar conflicto por el momento
//{ // Conflicto en camino con César
{//César Betancurth
//Carlos Silva
    // Nuevos cambios despues de crear el clon en github
    // Estos cambios *eventualmente* se van a ir al clon
    public class Program // cambio conflictivo en master
    {
        public static void Main(string[] args)
        {
			//Andrea Rueda Conflito con Andrea (Mijail)
            CreateHostBuilder(args).Build().Run();
        }
        //Alex Morales
        // otro cambio conflictivo en master
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        //Name: Juan Moyano
    }
}
