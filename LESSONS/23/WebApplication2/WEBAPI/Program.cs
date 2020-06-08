using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Hosting;
using System;

namespace WEBAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHost(o => o.UseStartup<Startup>())
                .Build()
                .Run();
                
        }
    }

    internal class Startup
    {
        private void Configure()
        {

        }
    }
}
