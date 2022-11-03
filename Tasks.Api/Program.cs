using Amazon;
using Amazon.DynamoDBv2;
using Amazon.Internal;
using FastEndpoints;
using FastEndpoints.Swagger;
using Tasks.Api.Contracts.Response;
using Tasks.Api.Repositories;
using Tasks.Api.Services;
using Tasks.Api.Validation;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

builder.Services.AddAWSLambdaHosting(LambdaEventSource.HttpApi);

builder.Services.AddFastEndpoints();
builder.Services.AddSwaggerDoc();

builder.Services.AddSingleton<IAmazonDynamoDB>(_ => new AmazonDynamoDBClient(RegionEndpoint.USEast1));
builder.Services.AddSingleton<ITaskRepository>(provider =>
    new TaskRepository(provider.GetRequiredService<IAmazonDynamoDB>(),
        config.GetValue<string>("Database:TableName")));

builder.Services.AddSingleton<ITaskService, TaskService>();
var app = builder.Build();

app.UseMiddleware<ValidationExceptionMiddleware>();
app.UseFastEndpoints(x =>
{
    
    x.Errors.ResponseBuilder = (failures, _) =>
    {
        return new ValidationFailureResponse
        {
            Errors = failures.Select(y => y.ErrorMessage).ToList()
        };
    };
});

app.UseOpenApi();
app.UseSwaggerUi3(s => s.ConfigureDefaults());

app.Run();