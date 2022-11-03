using FastEndpoints;
using Tasks.Api.Contracts.Response;
using Tasks.Api.Endpoints;

namespace Tasks.Api.Summaries;

public class GetTaskSummary : Summary<GetTaskEndpoint>
{
    public GetTaskSummary()
    {
        Summary = "Returns a single task by id";
        Description = "Returns a single task by id";
        Response<GetAllTasksResponse>(200, "Successfully found and returned the task");
        Response(404, "The task does not exist in the system");
    }
}