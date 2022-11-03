using System.Collections.Generic;
namespace Tasks.Api.Contracts.Response;

public class GetAllTasksResponse
{
    public List<TaskResponse> Tasks { get; init; } = new List<TaskResponse>();
}