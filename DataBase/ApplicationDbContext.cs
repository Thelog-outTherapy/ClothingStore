using Microsoft.EntityFrameworkCore;
using Models.DAL;

namespace DataBase;

public class ApplicationDbContext  : DbContext
{
    public DbSet<Product> Products { get; set;}
    public DbSet<Order> Orders { get; set;}
    public DbSet<User> Users { get; set;}
    public DbSet<Basket> Basket { get; set;}
    public DbSet<Feedback> Feedbacks { get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlite("Data Source=ClothingStore.db");
    }
}