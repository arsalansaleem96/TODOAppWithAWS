using System.Text.Json.Serialization;

namespace Tasks.App.Data.Enum
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TaskStatus
    {
        NotStarted = 0,
        InProgress = 1,
        Completed = 2,
    }
}
