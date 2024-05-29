using Microsoft.EntityFrameworkCore;
using sampleAPI.Entity;

namespace sampleAPI.Data
{
    public class PostDBContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public PostDBContext(DbContextOptions<PostDBContext> dbContextOptions):
            base(dbContextOptions)
        {
            
        }
    }
}
