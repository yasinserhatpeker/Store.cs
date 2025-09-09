using PekerStore.Data.Concrete;
namespace PekerStore.Data.Abstract;

public interface IStoreRepository
{
    IQueryable<Product> Products { get; }
    
    void CreateProduct(Product product);
}