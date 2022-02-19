using ProductOperation.Models;

namespace ProductOperation.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();
    }
}
