using Demo_Dapper.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
var dbString = builder.Configuration.GetSection("DbString").Value;
builder.Services.AddSingleton(provider => new CustomerRepository(dbString));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();

var app = builder.Build();
app.UseExceptionHandler(builder =>
{
    builder.Run(async context =>
    {
        var error = context.Features.Get<IExceptionHandlerPathFeature>().Error;
        context.Response.ContentType = "application/json";
        await context.Response.WriteAsync(error.Message);
    });
});

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();
app.Run();
