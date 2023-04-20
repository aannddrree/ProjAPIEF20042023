using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProjAPIEF20042023.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ProjAPIEF20042023Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ProjAPIEF20042023Context") ?? throw new InvalidOperationException("Connection string 'ProjAPIEF20042023Context' not found.")));

// Add services to the container.

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
