using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

namespace L22_C01_empty_asp_net_core_app_middleware
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Host.CreateDefaultBuilder(args)
				.ConfigureWebHostDefaults(builder => builder.UseStartup<Startup>())
				.Build()
				.Run();
		}
	}

	public class Startup
	{
		public void Configure(
			IApplicationBuilder application,
			IHostEnvironment environment)
		{
			if (environment.IsDevelopment())
			{
				application.UseDeveloperExceptionPage();
			}

			application.Map("/hello", b => b.Run(HelloRequestHandler));
			application.Map("/world", b => b.Run(WorldRequestHandler));
			application.Run(DefaultRequestHandler);
		}

		private static Task DefaultRequestHandler(HttpContext context)
		{
			return context.Response.WriteAsync("<body><h1>hello world</h1></body>");
		}

		private static Task HelloRequestHandler(HttpContext context)
		{
			var name = context.Request.Query["name"];
			return context.Response.WriteAsync($"<body><h1>hello {name}</h1></body>");
		}

		private static Task WorldRequestHandler(HttpContext context)
		{
			var random = new Random();
			var number = random.Next(2);
			if (number % 2 == 0)
			{
				throw new Exception("Something wrong");
			}

			return context.Response.WriteAsync("<body><h1>world</h1></body>");
		}
	}
}