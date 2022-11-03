using System.Text.Json.Serialization;

namespace Tasks.Api.Domain.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum TaskStatus
{
    NotStarted = 0,
    InProgress = 1,
    Completed = 2,
}

