using WebApplication2.model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WebApplication2
{
	public class Startup
	{
		//  оллекци€ сервисов
		//
		public void ConfigureServices(IServiceCollection services)
		{
			// Lifetime
			//   Singleton == 1 единица на все приложение
			//   Scoped == создает экземпл€р один раз на определенный скоуп == 
			//                                        на один http запрос
			//   Transient == создать экземпл€р каждый раз, когда его запрос€т
			services.AddSingleton<IStorage, Storage>();

			// ћетод AddMvc добавл€ет все зависимости которые нужны фрейсворку MVC дл€ работы
			services
				.AddMvc(options =>
				{
					options.RespectBrowserAcceptHeader = true;
				}
				)
				.AddXmlSerializerFormatters();
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseRouting();
			app.UseEndpoints(endpoints => endpoints.MapDefaultControllerRoute());
		}
	}
}