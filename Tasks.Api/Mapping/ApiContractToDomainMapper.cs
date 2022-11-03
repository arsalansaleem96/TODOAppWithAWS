using Tasks.Api.Contracts.Requests;
using Tasks.Api.Domain.Common;
using Tasks.Api.Domain.Entities;

namespace Tasks.Api.Mapping;

public static class ApiContractToDomainMapper
{
    public static TaskItem ToTask(this CreateTaskRequest request)
    {
        return new TaskItem
        {
            Id = TaskId.From(Guid.NewGuid()),
            Name = Name.From(request.Name),
            Priority = Priority.From(request.Priority),
            Status = Status.From(request.Status),
        };
    }
    public static TaskItem ToTask(this UpdateTaskRequest request)
    {
        return new TaskItem
        {
            Id = TaskId.From(request.Id),
            Name = Name.From(request.Name),
            Priority = Priority.From(request.Priority),
            Status = Status.From(request.Status),
        };
    }
}