using DockerSampleAPI.Data;
using DockerSampleAPI.Interfaces;
using DockerSampleAPI.Repository;
using DockerSampleAPI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IMsgRepository, MsgRepository>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DatabaseContext>(options =>
{
    var connectionString = Configure.DockerConfigDb(builder.Configuration);
    Console.WriteLine("Connection String: " + connectionString);
    options.UseSqlServer(connectionString);

    

});


builder.WebHost.UseUrls("http://*:80");

var app = builder.Build();

DatabaseManagementServices.MigrationInitialisation(app);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
