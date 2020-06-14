using System;
using System.Net.Http;
using System.Text.Json;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;

namespace Reminder.Storage.WebApi
{
    public class ReminderItemStorage : IReminderItemStorage
    {
        private const string EndPointPrifix = "/api/reminders/";
        private readonly HttpClient _client;

        public ReminderItemStorage(string endPoint) : this
            (new HttpClient { BaseAddress = new Uri(endPoint) })
        {

        }
        
          

        public ReminderItemStorage(HttpClient client)
        {
            _client = client;
        }
        public void Add(ReminderItem[] items)
        {
            foreach (var item in items)
            {
                var dto = new ReminderItemDto(item);
                var payload = JsonSerializer.Serialize(dto);
                var content = new StringContent(payload,Encoding.Default,"application/json");
                var response= _client.PostAsync(EndPointPrifix, content)
                    .GetAwaiter()
                    .GetResult();
                if (response.StatusCode==HttpStatusCode.BadRequest)
                {
                    throw new ArgumentException("data was invalid");
                }
                if (response.StatusCode == HttpStatusCode.Conflict)
                {
                    throw new ArgumentException("Reminder item whis samoe id exists");
                }
            }
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public ReminderItem Find(Guid id)
        {
            var response = _client.GetAsync($"{EndPointPrifix}{id:N}")
                .GetAwaiter()
                .GetResult();
            var payload = response.Content.ReadAsStringAsync()
                .GetAwaiter()
                .GetResult();
            var dto = JsonSerializer.Deserialize<ReminderItemDto>(payload
                ,new JsonSerializerOptions 
                { PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                 ,Converters = { new JsonStringEnumConverter() }
                }
                
                );

            return new ReminderItem(
                Guid.Parse(dto.Id),
                dto.Title,
                dto.Message,
                DateTimeOffset.Parse(dto.DateTimeUTC),
                dto.UserId,
                dto.Status
                );
        }

        public ReminderItem[] FindBy(ReminderItemFilter filter)
        {
            throw new NotImplementedException();
        }

        public void Update(ReminderItem item)
        {
            throw new NotImplementedException();
        }
    }
}
