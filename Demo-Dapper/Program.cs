using Demo_Dapper.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
var dbString = builder.Configuration.GetSection("DbString").Value;
builder.Services.AddSingleton(provider => new CustomerRepository(dbString));
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
app.MapControllers();
app.Run();
