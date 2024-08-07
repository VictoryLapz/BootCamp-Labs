using Adoption_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Adoption_MVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        //Add your tables here
        public DbSet<Animal> Animals { get; set; }
    }
}
