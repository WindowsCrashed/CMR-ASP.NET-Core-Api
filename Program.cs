using CMRWebApi.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<CMRDbContext>(options =>
{
    options.UseMySql(builder.Configuration["ConnectionStrings:DbConnection"], new MySqlServerVersion(new Version()));
});

builder.Services.AddControllers();

builder.Services.Configure<JsonOptions>(options =>
{
    options.JsonSerializerOptions.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;
});

var app = builder.Build();

app.MapControllers();

var context = app.Services.CreateScope().ServiceProvider.GetService<CMRDbContext>();
SeedDatabase.Seed(context);

app.UseHttpsRedirection();

app.Run();
