using FluentValidation;
using Tasks.Api.Contracts.Requests;

namespace Tasks.Api.Validation;

public class UpdateTaskRequestValidator: AbstractValidator<UpdateTaskRequest>
{
    public UpdateTaskRequestValidator()
    {
        RuleFor(x => x.Name).NotEmpty();
        RuleFor(x => x.Priority).NotEmpty();
        RuleFor(x => x.Status).NotEmpty();
    }
}