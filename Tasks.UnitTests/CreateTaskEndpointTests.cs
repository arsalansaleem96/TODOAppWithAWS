using FastEndpoints;
using Microsoft.AspNetCore.Http;
using NSubstitute;
using Tasks.Api.Contracts.Requests;
using Tasks.Api.Domain.Common;
using Tasks.Api.Endpoints;
using Tasks.Api.Repositories;
using Tasks.Api.Services;
using Xunit;
using TaskStatus = Tasks.Api.Domain.Enums.TaskStatus;

namespace Tasks.UnitTests;

public class CreateTaskEndpointTests
{
    // private readonly CreateTaskEndpoint _sut;
    // private readonly ITaskService _taskService = Substitute.For<ITaskService>();
    // private readonly ITaskRepository _taskRepository = Substitute.For<ITaskRepository>();
    //
    // public CreateTaskEndpointTests()
    // {
    //     _sut = new CreateTaskEndpoint(_taskService);
    // }
    //
    // [Fact]
    // public async Task CreateTaskEndpoint_ShouldCreateTask_WhenCreateTaskRequestPassed()
    // {
    //     // Arrange
    //     
    //     var ep = Factory.Create<Endpoint>(ctx =>
    //         ctx.Request.RouteValues.Add("id", "1"));
    //     
    //     const string name = "Test Task";
    //     const int priority = 1;
    //     const TaskStatus status = TaskStatus.InProgress;
    //
    //     CreateTaskRequest req = new CreateTaskRequest()
    //     {
    //         Name = name,
    //         Priority = priority,
    //         Status = status,
    //     };
    //     
    //     
    //
    //     // Act
    //     
    //     var result = _sut.HandleAsync(req, CancellationToken.None);
    //
    //
    //     // Assert
    //
    // }
}