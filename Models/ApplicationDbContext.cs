using Microsoft.EntityFrameworkCore;
using Project.Models;
namespace Project.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }
        public DbSet<WeatherForecast> WeatherForecasts { get; set; }
    }
}