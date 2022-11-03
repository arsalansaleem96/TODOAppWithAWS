using FastEndpoints;
using Microsoft.AspNetCore.Authorization;
using Tasks.Api.Contracts.Requests;
using Tasks.Api.Contracts.Response;
using Tasks.Api.Mapping;
using Tasks.Api.Services;

namespace Tasks.Api.Endpoints;

[HttpPut("tasks/{id:guid}"), AllowAnonymous]
public class UpdateTaskEndpoint : Endpoint<UpdateTaskRequest, TaskResponse>
{
    private readonly ITaskService _taskService;

    public UpdateTaskEndpoint(ITaskService taskService)
    {
        _taskService = taskService;
    }

    public override async Task HandleAsync(UpdateTaskRequest req, CancellationToken ct)
    {
        var existingTask = await _taskService.GetAsync(req.Id);

        if (existingTask is null)
        {
            await SendNotFoundAsync(ct);
            return;
        }

        var task = req.ToTask();
        await _taskService.UpdateAsync(task);

        var taskResponse = task.ToTaskResponse();
        await SendOkAsync(taskResponse, ct);
    }
    
}