using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.model
{
	public class City
	{
		public Guid Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public int Population { get; set; }

		public City(string title, string description, int population)
		{
			Id = Guid.NewGuid();
			Title = title.Capitalize();
			Description = description;
			Population = population;
		}
	}
}
