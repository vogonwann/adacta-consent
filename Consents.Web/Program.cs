using System.Reflection;
using Consents.Data;
using Consents.Data.Worker;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IConsentConnectorRepository, ConsentConnectorRepository>();
builder.Services.AddScoped<IConsentUnitOfWork, ConsentUnitOfWork>();

LoadDatabasePlugins();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

void LoadDatabasePlugins()
{
    string pluginDirectory = "Path/To/Plugins";
    string[] dllFiles = Directory.GetFiles(pluginDirectory, "*.dll");

    var repositories = new List<IConsentConnectorRepository>();

    foreach (string dllFile in dllFiles)
    {
        var assembly = Assembly.LoadFrom(dllFile);
        var repositoryTypes = assembly.GetTypes().Where(type => typeof(IConsentConnectorRepository).IsAssignableFrom(type));

        repositories.AddRange(
            repositoryTypes.Select(repositoryType => (
                Activator.CreateInstance(repositoryType) ?? null)!)
                .Select(repository => (dynamic)repository)
                .Select(dummy => (IConsentConnectorRepository)dummy));
    }

    // Do something with the repositories
}