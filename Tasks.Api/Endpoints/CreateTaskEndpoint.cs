using FastEndpoints;
using Microsoft.AspNetCore.Authorization;
using Tasks.Api.Contracts.Requests;
using Tasks.Api.Contracts.Response;
using Tasks.Api.Mapping;
using Tasks.Api.Services;

namespace Tasks.Api.Endpoints;

[HttpPost("tasks"), AllowAnonymous]
public class CreateTaskEndpoint : Endpoint<CreateTaskRequest, TaskResponse>
{
    private readonly ITaskService _taskService;
    public CreateTaskEndpoint(ITaskService taskService)
    {
        _taskService = taskService;
    }

    public override async Task HandleAsync(CreateTaskRequest req, CancellationToken ct)
    {
        var task = req.ToTask();

        await _taskService.CreateAsync(task);
        
        var taskResponse = task.ToTaskResponse();
        await SendOkAsync(taskResponse, ct);
    }
}