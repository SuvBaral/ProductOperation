using Microsoft.EntityFrameworkCore;
using ProductOperation.Models;

namespace ProductOperation
{
    public class AppDBContext: DbContext 
    {
        public AppDBContext(DbContextOptions<AppDBContext> options)
        : base(options)
        {
        }
        public DbSet<Product> Products { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
            new Product() { ProductId = 1, Name = "Nike", Price = 5000M, Stock = 500M, Image = "../../assets/images/nike.jpg" });

            modelBuilder.Entity<Product>().HasData(
            new Product() { ProductId = 2, Name = "Puma", Price = 2000M, Stock = 400M, Image = "../../assets/images/puma.jpg" });

            modelBuilder.Entity<Product>().HasData(
            new Product() { ProductId = 3, Name = "Adidas", Price = 3000M, Stock = 500M, Image = "../../assets/images/Adidas.jpg" });

            modelBuilder.Entity<Product>().HasData(
            new Product() { ProductId = 4, Name = "Clarks", Price = 5000M, Stock = 600M, Image = "../../assets/images/Clarks.jpg" });

            modelBuilder.Entity<Product>().HasData(
            new Product() { ProductId = 5, Name = "Seeandwear", Price = 2000M, Stock = 400M, Image = "../../assets/images/Seeandwear.jpg" });

            modelBuilder.Entity<Product>().HasData(
            new Product() { ProductId = 6, Name = "Woodland", Price = 2000M, Stock = 500M, Image = "../../assets/images/Woodland.jpg" });
        }
    }
  
}
