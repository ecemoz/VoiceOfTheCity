using Microsoft.EntityFrameworkCore;
using VoiceOfTheCity.Data;
using VoiceOfTheCity.Repositories;
using VoiceOfTheCity.Services;
using AutoMapper;
using VoiceOfTheCity.Mappers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AppDbContext<AppDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IRepository<Report>, ReportRepository>();
builder.Services.AddScoped<IReportService, ReportService>();
builder.Services.AddAutoMapper(typeof(UserProfile));

var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
