// 1. Using to work with EntityFramework

using Microsoft.EntityFrameworkCore;
using universityApiBackend.DataAccess;
var builder = WebApplication.CreateBuilder(args);

// 2. Connetion with SQL 
const string CONNECTIONNAME = "UniversityDB";
var connectionString = builder.Configuration.GetConnectionString(CONNECTIONNAME);

// 3. Add Context

builder.Services.AddDbContext<UniversityContexts>(options => options.UseSqlServer(connectionString));


// Add services to the container.

//TODO: Connection with SQL Server Express



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
