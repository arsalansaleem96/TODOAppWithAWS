using Microsoft.AspNetCore.Components;
using Tasks.App.Data.Entities;
using Tasks.App.Services;

namespace Tasks.App.Pages
{
    public class IndexBase : ComponentBase
    {
        [Inject]
        NavigationManager NavigationManager { get; set; }

        [Inject]
        protected ITaskService TaskService { get; set; }

        protected TasksItem tasksItem;
        protected override async Task OnInitializedAsync()
        {
            tasksItem = await TaskService.GetAllAsync();
        }

        internal void Edit(Guid taskId)
        {
            NavigationManager.NavigateTo($"/task/{taskId}");
        }

        internal void Create()
        {
            NavigationManager.NavigateTo("/task");
        }

        internal async Task Delete(TaskItem task)
        {
            if (await TaskService.DeleteAsync(task.Id))
            {
                tasksItem = await TaskService.GetAllAsync();
                StateHasChanged();
            }
        }
    }
}
