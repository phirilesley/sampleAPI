using sampleAPI.Data;
using sampleAPI.Entity;

namespace sampleAPI.Specifications
{
    public class Productsbynameorderbydescsepc : BaseSpecification<Product>
    {
        public Productsbynameorderbydescsepc(string name) 
            :base(x => x.ProductName.Contains(name))
        {
            ApplyOrderByDescending(x => x.ProductName);
        }
    }
}
