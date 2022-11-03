using Tasks.Api.Contracts.Data;
using Tasks.Api.Domain.Entities;

namespace Tasks.Api.Mapping;

public static class DomainToDtoMapper
{
    public static TaskDto ToTaskDto(this TaskItem task)
    {
        return new TaskDto
        {
            Id = task.Id.Value.ToString(),
            Name = task.Name.Value,
            Priority = task.Priority.Value,
            Status = task.Status.Value,
        };
    }
}