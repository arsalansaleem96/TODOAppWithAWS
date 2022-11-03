using FastEndpoints;
using Tasks.Api.Contracts.Response;
using Tasks.Api.Endpoints;

namespace Tasks.Api.Summaries;

public class CreateTaskSummary : Summary<CreateTaskEndpoint>
{
    public CreateTaskSummary()
    {
        Summary = "Creates a new task in the system";
        Description = "Creates a new task in the system";
        Response<TaskResponse>(201, "Task was successfully created");
        Response<ValidationFailureResponse>(400, "The request did not pass validation checks");
    }
}