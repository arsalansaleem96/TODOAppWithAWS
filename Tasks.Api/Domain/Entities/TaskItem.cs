using Tasks.Api.Domain.Common;

namespace Tasks.Api.Domain.Entities;

public class TaskItem
{
    public TaskId Id { get; init; } = TaskId.From(Guid.NewGuid());
    
    public Name Name { get; init; } = default!;

    public Priority Priority { get; init; } = default!;
    
    public Status Status { get; init; } = default!;
}