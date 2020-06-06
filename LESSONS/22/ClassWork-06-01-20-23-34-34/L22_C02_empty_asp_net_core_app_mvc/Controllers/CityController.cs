using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace L22_C02_empty_asp_net_core_app_mvc.Controllers
{
	public class City
	{
		public Guid Id { get; set; }
		public string Title { get; set; }
		public DateTimeOffset Datetime { get; set; }
		public int Population { get; set; }

		public City()
		{
		}

		public City(string title, DateTimeOffset datetime, int population)
		{
			Id = Guid.NewGuid();
			Title = title;
			Datetime = datetime;
			Population = population;
		}
	}

	public class Storage
	{
		private static Storage _instance;

		public static Storage Instance =>
			_instance ??= new Storage();

		public List<City> Items { get; } = new List<City>
		{
			new City("Moscow", DateTimeOffset.Parse("1147.02.03"), 16000000),
			new City("Saint Petersburg", DateTimeOffset.Parse("1300.02.03"), 4_000_000),
		};
	}

	[Route("/api/cities")]
	public class CityController : ControllerBase
	{
		[HttpGet]
		public IActionResult List()
		{
			return Ok(Storage.Instance.Items);
		}

		[HttpGet("{id}")]
		public IActionResult Get(Guid id)
		{
			var item = Storage.Instance.Items.FirstOrDefault(_ => _.Id == id);
			if (item == null)
			{
				return NotFound();
			}
			return Ok(item);
		}

		[HttpPost]
		public IActionResult Create()
		{
			// Create city and item to collection
			throw new NotImplementedException();
		}
	}
}