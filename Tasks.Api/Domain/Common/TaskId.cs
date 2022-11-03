using ValueOf;

namespace Tasks.Api.Domain.Common;

public class TaskId : ValueOf<Guid, TaskId>
{
    protected override void Validate()
    {
        if (Value == Guid.Empty)
        {
            throw new ArgumentException("Task Id cannot be empty", nameof(TaskId));
        }
    }
}
