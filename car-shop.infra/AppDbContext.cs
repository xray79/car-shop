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
            },
            new Product
            {
                Id = 2,
                Make = "Audi",
                Model = "A4",
                Price = 28000,
                Stock = 15
            },
            new Product
            {
                Id = 3,
                Make = "Mercedes-Benz",
                Model = "C-Class",
                Price = 32000,
                Stock = 8
            },
            new Product
            {
                Id = 4,
                Make = "Tesla",
                Model = "Model 3",
                Price = 40000,
                Stock = 12
            },
            new Product
            {
                Id = 5,
                Make = "Ford",
                Model = "Mustang",
                Price = 35000,
                Stock = 6
            },
            new Product
            {
                Id = 6,
                Make = "Honda",
                Model = "Civic",
                Price = 22000,
                Stock = 20
            },
            new Product
            {
                Id = 7,
                Make = "Toyota",
                Model = "Corolla",
                Price = 21000,
                Stock = 18
            },
            new Product
            {
                Id = 8,
                Make = "Volkswagen",
                Model = "Golf",
                Price = 25000,
                Stock = 14
            },
            new Product
            {
                Id = 9,
                Make = "Chevrolet",
                Model = "Camaro",
                Price = 37000,
                Stock = 5
            },
            new Product
            {
                Id = 10,
                Make = "Nissan",
                Model = "Altima",
                Price = 23000,
                Stock = 16
            });
    }
}