using WebApplication2.model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WebApplication2
{
	public class Startup
	{
		// ��������� ��������
		//
		public void ConfigureServices(IServiceCollection services)
		{
			// Lifetime
			//   Singleton == 1 ������� �� ��� ����������
			//   Scoped == ������� ��������� ���� ��� �� ������������ ����� == 
			//                                        �� ���� http ������
			//   Transient == ������� ��������� ������ ���, ����� ��� ��������
			services.AddSingleton<IStorage, Storage>();

			// ����� AddMvc ��������� ��� ����������� ������� ����� ���������� MVC ��� ������
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