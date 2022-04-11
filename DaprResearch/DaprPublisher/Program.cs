using Dapr.Client;
using System.Text.Json.Serialization;

for (int i = 0; i < 10; i++)
{
    var user = new User(i);
    using var client = new DaprClientBuilder().Build();

    await client.PublishEventAsync("user_pub_sub", "users", user);
    Console.WriteLine("Published data: " + user);

    await Task.Delay(1000);
}

public record User([property: JsonPropertyName("userId")] int UserId);