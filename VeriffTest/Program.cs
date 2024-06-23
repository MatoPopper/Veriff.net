using Veriff.net.Shared;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.Configure<VeriffConfig>(builder.Configuration.GetRequiredSection("Veriff"));

builder.Services.AddVeriffDotNet();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();




