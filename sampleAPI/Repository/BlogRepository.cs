using Microsoft.EntityFrameworkCore;
using sampleAPI.Data;
using sampleAPI.Entity;

namespace sampleAPI.Repository
{
    public class BlogRepository : Repository<Blog>, IBlogRepository
    {
        public BlogRepository(BlogDbContext dbContext) : base(dbContext)
        {
        }
    }
}
