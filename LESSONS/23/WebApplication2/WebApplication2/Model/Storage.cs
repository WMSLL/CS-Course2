using Microsoft.AspNetCore.Authentication.OAuth.Claims;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication2.ViewModels;

namespace WebApplication2.model
{
	public class Storage : IStorage
	{
		public List<City> Items { get; } = new List<City>
		{
			new City("Moscow", "The capital of Russia", 16000000),
			new City("Saint Petersburg", "The famous model", 6_000_000),
		};

		public void Create(City city)
		{
			Items.Add(city);
		}

		public IEnumerable<City> FindAll()
		{
			return Items
				.OrderByDescending(city => city.Population)
				.ThenBy(city => city.Title);
		}

		public City FindById(Guid id)
		{
			return Items
				.FirstOrDefault(_ => _.Id == id);
		}

		public void Delete (Guid id)
        {
			var item = Items.FirstOrDefault(_ => _.Id == id);
			Items.Remove(item);
		}

		public City FindByTitle(string title)
		{
			return Items.FirstOrDefault(
				item => string.Equals(item.Title, title, StringComparison.OrdinalIgnoreCase)
			);
		}

        public City Update(Guid id,UpdateCityViewModel model)
        {
			var item= Items.FirstOrDefault(_ => _.Id == id);
			item.Population = model.Population;
			item.Description = model.Description;
			return item;
		}
    }
}
