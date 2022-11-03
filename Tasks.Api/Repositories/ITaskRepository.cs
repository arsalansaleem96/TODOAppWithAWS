using Tasks.Api.Contracts.Data;

namespace Tasks.Api.Repositories;

public interface ITaskRepository
{
    Task<bool> CreateAsync(TaskDto task);

    Task<TaskDto?> GetAsync(Guid? id, string? name);

    Task<bool> UpdateAsync(TaskDto task);

    Task<bool> DeleteAsync(Guid id);
}