using FluentValidation;
using FluentValidation.Results;
using Tasks.Api.Domain.Common;
using Tasks.Api.Domain.Entities;
using Tasks.Api.Mapping;
using Tasks.Api.Repositories;

namespace Tasks.Api.Services;

public class TaskService : ITaskService
{
    private readonly ITaskRepository _taskRepository;

    public TaskService(ITaskRepository taskRepository)
    {
        _taskRepository = taskRepository;
    }

    public async Task<bool> CreateAsync(TaskItem task)
    {
        // var existingTask = await _taskRepository.GetAsync(id: task.Id.Value, name: task.Name.Value);
        // if (existingTask is not null)
        // {
        //     var message = $"A task with and name = {task.Name}  already exists";
        //     throw new ValidationException(message, new []
        //     {
        //         new ValidationFailure(nameof(TaskItem), message)
        //     });
        // }

        var taskDto = task.ToTaskDto();
        return await _taskRepository.CreateAsync(taskDto);
    }

    public async Task<TaskItem?> GetAsync(Guid id)
    {
        var taskDto = await _taskRepository.GetAsync(id: id, name: string.Empty);
        return taskDto?.ToTask();
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        return await _taskRepository.DeleteAsync(id);
    }

    public async Task<bool> UpdateAsync(TaskItem task)
    {
        var taskDto = task.ToTaskDto();
        return await _taskRepository.UpdateAsync(taskDto);
    }
}