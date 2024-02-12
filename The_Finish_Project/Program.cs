using AutoMapper;
using BL;
using DL.DLFunction;
using DL.Models;
using DTO.DTO;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUserBL,UserBL>();
builder.Services.AddScoped<IUserDL,UserDL>();
builder.Services.AddAutoMapper(typeof(DriverMapper));
builder.Services.AddDbContext<DriverDbContext>(options =>
    options.UseSqlServer("Server=DESKTOP-M884RIP;Database=DriverDB;Trusted_Connection=True;TrustServerCertificate=True;"));

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
