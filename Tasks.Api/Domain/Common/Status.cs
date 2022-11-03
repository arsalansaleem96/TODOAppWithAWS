using FluentValidation;
using FluentValidation.Results;
using ValueOf;
using Tasks.Api.Domain.Enums;
using TaskStatus = Tasks.Api.Domain.Enums.TaskStatus;

namespace Tasks.Api.Domain.Common;
public class Status : ValueOf<TaskStatus, Status>
{
    protected override void Validate()
    {
        // if (Value == TaskStatus.Completed)
        // {
        //     var message = $"{Value} cannot be empty";
        //     throw new ValidationException(message, new []
        //     {
        //         new ValidationFailure(nameof(Status), message)
        //     });
        // }
    }
}