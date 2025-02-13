using apicsharp.Database.Migrations;
using apicsharp.Models;
using FluentMigrator.Runner;
using LinqToDB;
using LinqToDB.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddSingleton<IRepo, Repo>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

var connectionString = "Server=localhost;Port=5432;Database=fiap;User Id=postgres;Password=123;";

var serviceProvider = new ServiceCollection()
    .AddFluentMigratorCore()
    .ConfigureRunner(rb => rb
        .AddPostgres()
        .WithGlobalConnectionString(connectionString)
        .ScanIn(typeof(CreateInitialDatabase).Assembly))
    .AddLogging(lb => lb.AddFluentMigratorConsole())
    .BuildServiceProvider();

using (var scope = serviceProvider.CreateScope())
{
    var runner = scope.ServiceProvider.GetRequiredService<IMigrationRunner>();
    runner.MigrateUp();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
