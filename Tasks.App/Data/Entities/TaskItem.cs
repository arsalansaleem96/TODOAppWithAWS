using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tasks.App.Data.Enum;

namespace Tasks.App.Data.Entities
{
    public class TaskItem
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = default!;
        [JsonPropertyName("name")]
        [Required]
        public string Name { get; set; } = default!;
        [JsonPropertyName("priority")]
        [Required]
        [Range(minimum: 1, maximum: 9)]
        public int Priority { get; set; } = default!;
        [JsonPropertyName("status")]
        [Required]
        public Enum.TaskStatus Status { get; set; } = default!;
    }
}
