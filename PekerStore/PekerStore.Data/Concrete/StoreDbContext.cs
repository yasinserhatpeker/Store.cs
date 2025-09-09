using System.Net.Http.Headers;
using Microsoft.EntityFrameworkCore;

namespace PekerStore.Data.Concrete;

public class StoreDbContext : DbContext
{
    public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
    {

    }
    public DbSet<Product> Products => Set<Product>();
}