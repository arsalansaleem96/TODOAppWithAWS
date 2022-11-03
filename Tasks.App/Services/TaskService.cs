using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Tasks.App.Data.Entities;

namespace Tasks.App.Services
{
    public class TaskService : ITaskService
    {
        private readonly HttpClient _client;

        private JsonSerializerOptions _options;

        public TaskService(HttpClient client)
        {
            _client = client;
            _options = new JsonSerializerOptions
            {
                Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) }
            };
        }

        public async Task<bool> CreateAsync(TaskItem task)
        {
            var json = JsonSerializer.Serialize(task);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("/tasks",content);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return true;
            }

            return false;
        }

        public async Task<bool> DeleteAsync(string id)
        {
            var response = await _client.DeleteAsync($"/tasks/{id}");
            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return false;
            }
            return true;
        }

        public async Task<TasksItem> GetAllAsync()
        {
            var response = await _client.GetAsync("/tasks");
            if(response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return null;
            }

            var jsonString = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<TasksItem>(jsonString, _options);
        }

        public async Task<TaskItem> GetAsync(string id)
        {
            var response = await _client.GetAsync($"/tasks/{id}");
            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return null;
            }

            var jsonString = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<TaskItem>(jsonString, _options);
        }

        public async Task<bool> UpdateAsync(TaskItem task)
        {
            var json = JsonSerializer.Serialize(task);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PutAsync($"/tasks/{task.Id}", content);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                return true;

            }
            return false;
        }
    }
}
