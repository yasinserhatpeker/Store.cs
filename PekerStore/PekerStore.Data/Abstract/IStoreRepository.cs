using PekerStore.Data.Concrete;
namespace PekerStore.Data.Abstract;

public interface IStoreRepository
{
    IQueryable<Product> products { get; }
    
    void CreateProduct(Product product);
}