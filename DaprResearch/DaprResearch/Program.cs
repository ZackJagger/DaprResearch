using System.Text.Json.Serialization;
using Dapr;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseCloudEvents();

app.MapSubscribeHandler();

app.MapPost("/users", [Topic("user_pub_sub", "users")] (User user) =>
{
    Console.WriteLine("Subscriber received: " + user);
    return Results.Ok(user);
});

app.Run();

public record User([property: JsonPropertyName("userId")] int UserId);