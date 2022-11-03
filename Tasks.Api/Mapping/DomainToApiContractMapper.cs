using Tasks.Api.Contracts.Response;
using Tasks.Api.Domain.Common;
using Tasks.Api.Domain.Entities;

namespace Tasks.Api.Mapping;

public static class DomainToApiContractMapper
{
    public static TaskResponse ToTaskResponse(this TaskItem task)
    {
        return new TaskResponse
        {
            Id = task.Id.Value,
            Name = task.Name.Value,
            Priority = task.Priority.Value,
            Status = task.Status.Value,
        };
    }
    public static GetAllTasksResponse ToTasksResponse(this List<TaskItem> tasks)
    {
        return new GetAllTasksResponse
        {
            Tasks = tasks.Select(x => new TaskResponse
            {
                Id = x.Id.Value,
                Name = x.Name.Value,
                Priority = x.Priority.Value,
                Status = x.Status.Value,
            }).ToList()
        };
    }
}