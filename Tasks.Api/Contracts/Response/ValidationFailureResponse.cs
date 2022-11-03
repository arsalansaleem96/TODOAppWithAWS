namespace Tasks.Api.Contracts.Response;

public class ValidationFailureResponse
{
    public List<string> Errors { get; init; } = new();
}