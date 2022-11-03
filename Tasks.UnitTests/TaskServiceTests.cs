using NSubstitute;
using Tasks.Api.Domain.Common;
using Tasks.Api.Domain.Entities;
using Tasks.Api.Repositories;
using Tasks.Api.Services;
using Xunit;

namespace Tasks.UnitTests;

public class TaskServiceTests
{
    // private readonly ITaskService _sut;
    // private readonly ITaskRepository _taskRepository = Substitute.For<ITaskRepository>();
    //
    // public TaskServiceTests()
    // {
    //     _sut = new TaskService(_taskRepository);
    // }
    //
    // [Fact]
    // public async Task CreateAsync_ShouldCreateTask_WhenAllParametersAreValid()
    // {
    //     // Arrange
    //
    //     var taskId = Guid.NewGuid(); 
    //     var taskName = "Test Task";
    //     var taskPriority = 1;
    //     var taskStatus = TaskStatus.NotStarted;
    //     
    //     var task = new TaskItem(
    //     {
    //         Name = taskName,
    //         
    //     });
    //
    //     // Act
    //
    //     // Assert
    // }
}