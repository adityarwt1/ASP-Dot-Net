using Microsoft.AspNetCore.Builder;
using MyApi.Services;

var builder = WebApplication.CreateBuilder(args);

// 1) Bind settings
builder.Services.Configure<MongoClientSettings>(
    builder.Configuration.GetSection("MongoSettings"));

// 2) Register MongoServices
builder.Services.AddSingleton<MongoServices>();

builder.Services.AddControllers();

var app = builder.Build();

// Redirect route
app.MapGet("/", () => {
    return Results.Redirect("/hellow");
});

app.MapGet("/hellow", () => {
    return Results.Ok(new { message = "Message from the hellow route" });
});

// 3) IMPORTANT: Map controllers
app.MapControllers();

app.Run();
