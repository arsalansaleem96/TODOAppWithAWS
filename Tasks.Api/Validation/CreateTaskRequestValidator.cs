using FluentValidation;
using Tasks.Api.Contracts.Requests;

namespace Tasks.Api.Validation;

public class CreateTaskRequestValidator: AbstractValidator<CreateTaskRequest>
{
    public CreateTaskRequestValidator()
    {
        RuleFor(x => x.Name).NotEmpty();
        RuleFor(x => x.Priority).NotEmpty();
        RuleFor(x => x.Status).NotEmpty();
    }
}