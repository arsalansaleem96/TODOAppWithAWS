using Tasks.App.Data.Entities;

namespace Tasks.App.Services
{
    public interface ITaskService
    {
        Task<bool> CreateAsync(TaskItem task);
        Task<TaskItem> GetAsync(string id);
        Task<bool> DeleteAsync(string id);
        Task<bool> UpdateAsync(TaskItem task);
        Task<TasksItem> GetAllAsync();
    }
}
