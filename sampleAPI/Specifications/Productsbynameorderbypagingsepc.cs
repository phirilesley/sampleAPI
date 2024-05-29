using sampleAPI.Data;
using sampleAPI.Entity;

namespace sampleAPI.Specifications
{
    public class Productsbynameorderbypagingsepc : BaseSpecification<Product>
    {
        public Productsbynameorderbypagingsepc(string name,int pageNumber, int pageSize) 
            :base(x => x.ProductName.Contains(name))
        {
            ApplyOrderBy(x => x.ProductName);
            ApplyPaging(pageNumber, pageSize);

        }
    }
}
