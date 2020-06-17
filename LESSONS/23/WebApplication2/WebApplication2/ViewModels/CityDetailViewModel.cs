using WebApplication2.model;

namespace WebApplication2.ViewModels
{
	public class CityDetailViewModel
	{
		public string Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public int Population { get; set; }

		public CityDetailViewModel(City city)
		{
			Id = city.Id.ToString("N");
			Title = city.Title;
			Description = city.Description;
			Population = city.Population;
		}
	}
}
