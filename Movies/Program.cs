using Microsoft.EntityFrameworkCore;
using Movies.Data;
using Movies.Reposatory.CategoryRepo;
using Movies.Reposatory.MovieRepo;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbcontext>(x=> x.UseSqlServer(builder.Configuration.GetConnectionString("conn")));
builder.Services.AddScoped<IMovieRepo, MovieRepo>();
builder.Services.AddScoped<ICategoryRepo, CategoryRepo>();
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
