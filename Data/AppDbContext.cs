using Microsoft.EntityFrameworkCore;
using VoiceOfTheCity.Models;

namespace VoiceOfTheCity.Data{

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users {get; set;}
        public DbSet<Report> Reports {get; set;}
        }
    }