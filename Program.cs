using Microsoft.EntityFrameworkCore;
using RestauranteApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=RestauranteApi.db"));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
