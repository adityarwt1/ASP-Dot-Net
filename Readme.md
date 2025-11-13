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
