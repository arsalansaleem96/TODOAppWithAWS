using FastEndpoints;
using Microsoft.AspNetCore.Authorization;
using Tasks.Api.Contracts.Requests;
using Tasks.Api.Contracts.Response;
using Tasks.Api.Mapping;
using Tasks.Api.Services;

namespace Tasks.Api.Endpoints;

[HttpGet("tasks/{id:guid}"), AllowAnonymous]
public class GetTaskEndpoint : Endpoint<GetTaskRequest, TaskResponse>
{
    private readonly ITaskService _taskService;

    public GetTaskEndpoint(ITaskService taskService)
    {
        _taskService = taskService;
    }

    public override async Task HandleAsync(GetTaskRequest req, CancellationToken ct)
    {
        var task = await _taskService.GetAsync(req.Id);

        if (task is null)
        {
            await SendNotFoundAsync(ct);
            return;
        }

        var taskResponse = task.ToTaskResponse();
        await SendOkAsync(taskResponse, ct);
    }
}
 