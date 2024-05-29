using sampleAPI.Entity;

namespace sampleAPI.Specifications
{
    public class ProductByIdspec : BaseSpecification<Product>
    {
        public ProductByIdspec(int id): base(x => x.ProductId == id)
        {
            
        }
    }
}
