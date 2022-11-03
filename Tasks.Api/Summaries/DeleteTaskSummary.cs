using FastEndpoints;
using Tasks.Api.Endpoints;

namespace Tasks.Api.Summaries;

public class DeleteTaskSummary : Summary<DeleteTaskEndpoint>
{
    public DeleteTaskSummary()
    {
        Summary = "Deleted a task the system";
        Description = "Deleted a task the system";
        Response(204, "The task was deleted successfully");
        Response(404, "The task was not found in the system");
    }
}