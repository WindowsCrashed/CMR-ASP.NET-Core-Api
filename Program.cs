using CMRWebApi.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<CMRDbContext>(options =>
{
    options.UseMySql(builder.Configuration["ConnectionStrings:DbConnection"], new MySqlServerVersion(new Version()));
});

builder.Services.AddControllers().AddNewtonsoftJson();

builder.Services.Configure<MvcNewtonsoftJsonOptions>(options =>
{
    options.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
});

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "_allowSpecificOrigins",
                      policy =>
                      {
                        policy.WithOrigins("http://localhost:3000");
                      });
});

var app = builder.Build();

app.MapControllers();

var context = app.Services.CreateScope().ServiceProvider.GetService<CMRDbContext>();
SeedDatabase.Seed(context);

app.UseHttpsRedirection();
app.UseCors("_allowSpecificOrigins");
app.UseStaticFiles();

app.Run();
