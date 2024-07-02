using Microsoft.EntityFrameworkCore;
using pixy.Interfaces;
using pixy.Repository;
using pixy.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<Context>(options => options.UseNpgsql("User ID=azurial;Password=Rotar3040;Host=localhost;Port=5432;Database=PixyDatabase"));
builder.Services.AddScoped<ICrewRepository, CrewRepository>();
builder.Services.AddScoped<ICrewService, CrewService>();
builder.Services.AddControllers();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();
app.MapControllers();
app.Run();
