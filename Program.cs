using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapPost("/raw", (UserData data) =>
{
    // You already have the body as an object
    return Results.Ok(new { data });
});

app.Run();

public class UserData
{
    public string Name { get; set; }
    public int Age { get; set; }
}
