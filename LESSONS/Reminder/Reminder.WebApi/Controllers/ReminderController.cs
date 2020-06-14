using Microsoft.AspNetCore.Mvc;
using Reminder.Storage;
using Reminder.WebApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Reminder.WebApi.Controllers
{
    [Route("/api/reminders")]
    public class ReminderController : ControllerBase
    {
        private readonly IReminderItemStorage _storage;
        public ReminderController(IReminderItemStorage storage)
        {
            _storage = storage;
        }
        [HttpGet]
        // goto Почемуто передается в datetime дeфолтное время
        public IActionResult List(ReminderItemStatus status, DateTimeOffset datetime)
        {
            var items = _storage.FindBy(new ReminderItemFilter(status, datetime));
            var result = items.OrderBy(_ => _.DateTimeUTC).Select(item => new ReminderItemViewModel(item));
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            try
            {
                var item = _storage.Find(id);
                var result = new ReminderItemViewModel(item);
                return Ok(result);
            }
            catch (KeyNotFoundException )
            {
                return BadRequest();
            }
        }
        [HttpPost]
        public IActionResult Create([FromBody] CreateReminderItemViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var items = new ReminderItem[] { new ReminderItem(model.Id ?? Guid.NewGuid(),
                                        model.Title,
                                        model.Message,
                                        model.DateTimeUTC ?? DateTimeOffset.UtcNow,
                                        model.UserId)
                                            };
            try
            {
                _storage.Add(items);
            }
            catch (ArgumentException)
            {
                return Conflict();
            }

            return Ok(new ReminderItemViewModel(items));
        }
        [HttpPut("{id}")]

        public IActionResult Update(Guid id , [FromBody] UpdateReminderItemViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var target = _storage.Find(id);
                var item = new ReminderItem(
                    target.Id,
                    model.Title,
                    model.Message,
                    model.DateTimeUTC.GetValueOrDefault(),
                    target.UserId,
                    model.Status
                    );   
                _storage.Update(item);
                return Ok(new ReminderItemViewModel(item));
            }
            catch (KeyNotFoundException)
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _storage.Delete(id);
                return NoContent();
            }
            catch (KeyNotFoundException )
            {

                return NotFound();
            }
        }
    }
}
