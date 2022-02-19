using Microsoft.EntityFrameworkCore;
using ProductOperation.Models;

namespace ProductOperation.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDBContext _appDBContext;

        public ProductRepository(AppDBContext appDBContext)
        {
            this._appDBContext = appDBContext;
        }
        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _appDBContext.Products.ToListAsync();
        }

    }
}
