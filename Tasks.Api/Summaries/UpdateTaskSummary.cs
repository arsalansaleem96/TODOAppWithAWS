using FastEndpoints;
using Tasks.Api.Contracts.Requests;
using Tasks.Api.Contracts.Response;
using Tasks.Api.Endpoints;

namespace Tasks.Api.Summaries;

public class UpdateTaskSummary : Summary<UpdateTaskEndpoint>
{
    public UpdateTaskSummary()
    {
        Summary = "Updates an existing task in the system";
        Description = "Updates an existing task in the system";
        Response<TaskResponse>(201, "Task was successfully updated");
        Response<ValidationFailureResponse>(400, "The request did not pass validation checks");
    }
}