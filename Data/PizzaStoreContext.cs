using Microsoft.EntityFrameworkCore;

namespace BlazingPizza.Data;

public class PizzaStoreContext : DbContext
{
    public PizzaStoreContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderPizza> Pizzas { get; set; }
    public DbSet<PizzaSpecial> Specials { get; set; }
    public DbSet<PizzaTopping> Toppings { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configure OrderPizza relationships
        modelBuilder.Entity<OrderPizza>()
            .HasOne(p => p.Special)
            .WithMany()
            .HasForeignKey(p => p.SpecialId);
    }
}