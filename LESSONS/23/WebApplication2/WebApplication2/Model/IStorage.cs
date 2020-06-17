using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebApplication2.ViewModels;

namespace WebApplication2.model
{
    public interface IStorage
	{
		void Create(City city);
		IEnumerable<City> FindAll();
		City FindById(Guid id);
		City FindByTitle(string title);
		void Delete(Guid id);
		City Update(Guid id, UpdateCityViewModel model);
	}
}
