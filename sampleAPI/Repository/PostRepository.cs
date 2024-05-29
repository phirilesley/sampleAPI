using Microsoft.EntityFrameworkCore;
using sampleAPI.Data;
using sampleAPI.Entity;

namespace sampleAPI.Repository
{
    public class PostRepository : Repository<Post>, IPostRepository
    {
        public PostRepository(PostDBContext dbContext) : base(dbContext)
        {
        }
    }
}
