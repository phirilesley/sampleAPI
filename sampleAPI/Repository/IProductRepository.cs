using sampleAPI.Common;
using sampleAPI.Entity;

namespace sampleAPI.Repository
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<IEnumerable<Product>> GetProductsByName(string productName);
        Task<PaginatedList<Product>> GetAllProuctsWithPagging(int page, int pageSize, string searchTerm);
        Task<Product> GetProuductsByProductId(int productId);
    }
}
