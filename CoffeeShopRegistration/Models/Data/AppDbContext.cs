using Microsoft.EntityFrameworkCore;
namespace CoffeeShopRegistration.Models.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    //what table in my database
    public DbSet<User> User { get; set; }
}
