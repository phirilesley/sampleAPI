using sampleAPI.Entity;

namespace sampleAPI.Specifications
{
    public class ProductByNamespec : BaseSpecification<Product>
    {
        public ProductByNamespec(string proudctName) 
            :base(x => x.ProductName.Contains(proudctName))
        {
            
        }
    }
}
