// var builder = WebApplication.CreateBuilder(args);


// var app = builder.Build();


// app.Run();


// must be var
var builder  =  WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/" , ()=>{
    return new {message = "hellow"};
}).WithName("Home Page");

app.Run();