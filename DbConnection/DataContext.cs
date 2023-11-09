using LR4.Entities;
using Microsoft.EntityFrameworkCore;

namespace LR4.DbConnection;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> opts) : base(opts) { }

    public DbSet<Product> Products { get; set; }
    public DbSet<Size> Size { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>()
            .HasMany(t => t.Sizes)
            .WithOne()
            .OnDelete(DeleteBehavior.Cascade);
    }
}
