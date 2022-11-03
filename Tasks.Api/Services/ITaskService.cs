using Tasks.Api.Domain.Entities;

namespace Tasks.Api.Services;

using static Domain.Entities.TaskItem;

public interface ITaskService
{ 
    Task<bool> CreateAsync(TaskItem task);
    Task<TaskItem?> GetAsync(Guid id);
    Task<bool> DeleteAsync(Guid id);
    Task<bool> UpdateAsync(TaskItem task);
}