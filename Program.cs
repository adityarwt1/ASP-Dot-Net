// var builder = WebApplication.CreateBuilder(args);


// var app = builder.Build();


// app.Run();


// must be var
using Microsoft.AspNetCore.Http.HttpResults;

var builder  =  WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/" , ()=>{
    return Results.Ok(new {message = "200 response"});
}).WithName("Home Page");

app.Run();