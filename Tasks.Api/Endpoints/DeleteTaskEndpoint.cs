using FastEndpoints;
using Microsoft.AspNetCore.Authorization;
using Tasks.Api.Contracts.Requests;
using Tasks.Api.Services;

namespace Tasks.Api.Endpoints;

[HttpDelete("tasks/{id:guid}"), AllowAnonymous]
public class DeleteTaskEndpoint : Endpoint<DeleteTaskRequest>
{
    private readonly ITaskService _taskService;

    public DeleteTaskEndpoint(ITaskService taskService)
    {
        _taskService = taskService;
    }
    
    public override async Task HandleAsync(DeleteTaskRequest req, CancellationToken ct)
    {
        var deleted = await _taskService.DeleteAsync(req.Id);
        if (!deleted)
        {
            await SendNotFoundAsync(ct);
            return;
        }

        await SendNoContentAsync(ct);
    }
}