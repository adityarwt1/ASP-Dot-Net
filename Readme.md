# .Net complete note after finishing the expressjs/node

1. Bare minimum for the running

```cs
var builder  =  WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/" , ()=>{
    return new {message = "hellow"};
}).WithName("Home Page");

app.Run();
```

2. For sending the response ok

```cs

app.MapGet("/" , ()=>{
    return Results.Ok(new {message = "200 response"});
}).WithName("Home Page");

```

3. How to extract data from body

```cs
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
```
4. Api redirecting

```cs
var app = builder.Build();

app.MapGet("/", ()=>{
    return Results.Redirect("/hellow");
});

app.MapGet("/hellow",()=>{
    return Results.Ok(new {message = "Message from the helloow route"});
});
```