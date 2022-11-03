using TaskStatus = Tasks.Api.Domain.Enums.TaskStatus;

namespace Tasks.Api.Contracts.Requests;

public class UpdateTaskRequest
{
    public Guid Id { get; init; }
    
    public string Name { get; init; } = default!;

    public int Priority { get; init; } = default!;
    
    public TaskStatus Status { get; init; } = default!;
}