﻿using System;
using System.Linq;
using WebApplication2.model;
using WebApplication2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace WebApplication2.Controllers
{
    [Route("/api/cities")]
    public class CityController : ControllerBase
    {
        private readonly IStorage _storage;
        private readonly ILogger _logger;

        public CityController(IStorage storage, ILogger<CityController> logger)
        {
            _storage = storage;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult List()
        {
            var list = _storage.FindAll()
                .Select(city => new CityInfoViewModel(city))
                .ToList();

            return Ok(list);
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var item = _storage.FindById(id);
            if (item == null)
            {
                _logger.LogWarning("Not existing city requested");
                return NotFound();
            }

            return Ok(new CityDetailViewModel(item));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _storage.Delete(id);
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult Update(Guid id, [FromBody] UpdateCityViewModel model)
        {
            _storage.Update(id,model);
            return Ok();
        }
        [HttpPost]
        public IActionResult Create([FromBody] CreateCityViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var city = new City(
                model.Title.Trim(),
                model.Description.Trim(),
                model.Population);

            var duplicate = _storage.FindByTitle(city.Title);
            if (duplicate != null)
            {
                _logger.LogWarning("Duplicate city");
                return Conflict();
            }

            _storage.Create(city);

            return Ok(new CityDetailViewModel(city));
        }
    }
}
