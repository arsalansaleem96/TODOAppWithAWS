using System.Text.Json.Serialization;
using TaskStatus = Tasks.Api.Domain.Enums.TaskStatus;

namespace Tasks.Api.Contracts.Data;

public class TaskDto
{
    [JsonPropertyName("pk")]
    public string Pk => Id;

    [JsonPropertyName("sk")]
    public string Sk => Id;
    public string Id { get; set; } = default!;
    
    public string Name { get; set; } = default!;

    public int Priority { get; set; } = default!;
    
    public TaskStatus Status { get; set; } = default!;
}