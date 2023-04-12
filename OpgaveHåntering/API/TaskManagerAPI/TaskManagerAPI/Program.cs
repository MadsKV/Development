global using Microsoft.EntityFrameworkCore;
using System.Configuration;
using TaskManagerAPI.Data;
using TaskManagerAPI.Services.Interfaces;
using TaskManagerAPI.Services.TasksService;
using TaskManagerAPI.Services.UserService;
using ConfigurationManager = Microsoft.Extensions.Configuration.ConfigurationManager;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

ConfigurationManager configuration = builder.Configuration;

builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(
        configuration.GetConnectionString("TaskManagerConnectionString")));


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<ITasksService, TasksService>();
builder.Services.AddScoped<IUsersService, UsersService>();


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
