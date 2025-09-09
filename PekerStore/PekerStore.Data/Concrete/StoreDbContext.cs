using System.Net.Http.Headers;
using Microsoft.EntityFrameworkCore;

namespace PekerStore.Data.Concrete;

public class StoreDbContext : DbContext
{
    public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
    {

    }
    public DbSet<Product> Products => Set<Product>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>().HasData(
            new List<Product>()
            {
                new() {Id=1 , Name="Crime and Punishment", Price=10, Description="Dostoyevski Book",Category="Novel"},
                new() {Id=1 , Name="Anna Karenina", Price=20, Description="Tolstoy Book",Category="Novel"},
                new() {Id=1 , Name="The Double", Price=10, Description="Dostoyevski Book",Category="Novel"},
                new() {Id=1 , Name="Game of Thrones", Price=30, Description="GRM Book",Category="Fantastic"},
                new() {Id=1 , Name="Küçük Ağa", Price=40, Description="Tarık Buğra Book",Category="Novel"}

            }
        );
    }
}