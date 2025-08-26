using Rira_Task.Models;
using Microsoft.EntityFrameworkCore;

namespace Rira_Task.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // تبدیل Enum به رشته هنگام ذخیره در دیتابیس
            modelBuilder.Entity<Product>()
                .Property(p => p.Category)
                .HasConversion<string>();

            // Seed داده‌ها
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Product A", Category = Categories.Category1, Price = 100 },
                new Product { Id = 2, Name = "Product B", Category = Categories.Category1, Price = 150 },
                new Product { Id = 3, Name = "Product C", Category = Categories.Category2, Price = 120 },
                new Product { Id = 4, Name = "Product D", Category = Categories.Category3, Price = 200 },
                new Product { Id = 5, Name = "Product E", Category = Categories.Category1, Price = 80 }
            );
        }
    }
}
