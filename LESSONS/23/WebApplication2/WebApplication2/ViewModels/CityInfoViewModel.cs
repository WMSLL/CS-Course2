using WebApplication2.model;

namespace WebApplication2.ViewModels
{
	public class CityInfoViewModel
	{
		public string Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public int Population { get; set; }

		public CityInfoViewModel(City city)
		{
			Id = city.Id.ToString("N");
			Title = city.Title;
			Description = city.Description;
		    Population=city.Population;
		}
	}
}
