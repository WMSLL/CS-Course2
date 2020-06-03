using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics.CodeAnalysis;

namespace WebApplication1
{
    public class City
    { 
        public string Title { get; set; }
        public Guid Id { get; set; }
        public DateTimeOffset DateTime { get; set; }
        public int Population { get; set; }

        public City(string title, DateTimeOffset dateTime, int population)
        {
            Title = title;
            DateTime = dateTime;
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
