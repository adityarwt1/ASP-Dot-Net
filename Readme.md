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
