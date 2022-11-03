using FluentValidation;
using FluentValidation.Results;

namespace Tasks.Api.Domain.Common;
using ValueOf;

public class Name : ValueOf<string, Name>
{
    protected override void Validate()
    {
        if (string.IsNullOrEmpty(Value))
        {
            var message = $"{Value} cannot be empty";
            throw new ValidationException(message, new []
            {
                new ValidationFailure(nameof(Name), message)
            });
        }
    }
}