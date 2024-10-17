using car_shop.domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace car_shop.infra;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 1,
                Make = "BMW",
                Model = "330i",
                Price = 30000,
                Stock = 10,
            });
    }
}