using Tasks.Api.Contracts.Data;
using Tasks.Api.Domain.Common;
using Tasks.Api.Domain.Entities;

namespace Tasks.Api.Mapping;

public static class DtoToDomainMapper
{
    public static TaskItem ToTask(this TaskDto taskDto)
    {
        return new TaskItem
        {
            Id = TaskId.From(Guid.Parse(taskDto.Id)),
            Name = Name.From(taskDto.Name),
            Priority= Priority.From(taskDto.Priority),
            Status = Status.From(taskDto.Status),
        };
    }
}