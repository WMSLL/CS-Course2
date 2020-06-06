using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics.CodeAnalysis;

namespace WebApplication1
{
    public class City
    { 
        public string Title { get; set; }
        public Guid Id { get; set; }
        public string Description { get; set; }
        public int Population { get; set; }

        public City(string title, string description, int population)
        {
            Title = title;
            Description = description;
            Population = population;
            Id = Guid.NewGuid();
        }

    }
    public class CityController : ControllerBase
    {
        public IActionResult List()
        {
            throw Exception();
        }
    }
}
