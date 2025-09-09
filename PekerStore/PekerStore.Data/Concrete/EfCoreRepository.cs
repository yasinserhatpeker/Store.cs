using PekerStore.Data.Abstract;

namespace PekerStore.Data.Concrete;

public class EfCoreRepository : IStoreRepository
{
    private StoreDbContext _context;

    public EfCoreRepository(StoreDbContext context)
    {
        _context = context;
    }

    public IQueryable<Product> Products => _context.Products;

     public void CreateProduct(Product product)
    {
        throw new NotImplementedException();
    }
}