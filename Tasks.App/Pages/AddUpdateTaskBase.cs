using Microsoft.AspNetCore.Components;
using Tasks.App.Data.Entities;
using Tasks.App.Services;

namespace Tasks.App.Pages
{
    public class AddUpdateTaskBase : ComponentBase
    {
        [Inject]
        protected ITaskService TaskService { get; set; }

        [Parameter]
        public Guid? Id { get; set; }

        protected TaskItem model = new TaskItem();

        protected string Heading { get; set; }
        protected bool ShowError { get; set; } = false;
        protected bool ShowSuccess { get; set; } = false;


        protected override async Task OnInitializedAsync()
        {
            if (Id.HasValue)
            {
                model = await TaskService.GetAsync(Id.ToString());
                Heading = "Edit Task";
            }
            else
                Heading = "Create Task";
        }

        protected async Task HandleValidSubmit()
        {
            var success = false;
            if (!Id.HasValue)
            {
                success = await TaskService.CreateAsync(model);
                model = new TaskItem();
            }
            else
            {
               success = await TaskService.UpdateAsync(model);
            }

            ShowError = !success;
            ShowSuccess = success;

            StateHasChanged();
        }

    }
}
