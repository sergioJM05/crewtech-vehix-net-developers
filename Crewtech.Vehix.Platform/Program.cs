using Crewtech.Vehix.Platform.Generic.Domain.Model.Entities;
using Crewtech.Vehix.Platform.Generic.Interfaces.REST.Assemblers;
using Crewtech.Vehix.Platform.Generic.Interfaces.REST.Resources;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

/// <summary>
///Define the GET endpoint for retrieving a greeting
///</summary>
/// <param name="firstName">The first name of the developer. Can be null</param>
/// <param name="lastName">The last name of the developer. Can be null</param>
/// <returns> A greeting message. </returns>
/// 
app.MapGet("/greetings", (string? firstName, string? lastName) =>
{
    var developer = !string.IsNullOrWhiteSpace(firstName) && !string.IsNullOrWhiteSpace(lastName)
        ? new Developer(firstName, lastName)
        : null;
    var response = GreetDeveloperResponseAssembler.ToResponseFromEntity(developer);
    return Results.Ok(response);
}).WithName("GetGreeting").WithOpenApi();

/// <summary>
/// Define the POST endpoint for creating a greeting
/// </summary>
/// <param name="request">The request object containing the first and last name of the developer</param>
app.MapPost("/greetings", (GreetDeveloperRequest request) =>
{
    var developer = DeveloperAssembler.ToEntityFromRequest(request);
    var response = GreetDeveloperResponseAssembler.ToResponseFromEntity(developer);
    return Results.Created("/greetings", response);
}).WithName("CreateGreeting").WithOpenApi();

app.Run();

