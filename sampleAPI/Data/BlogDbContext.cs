using Microsoft.EntityFrameworkCore;
using sampleAPI.Entity;

namespace sampleAPI.Data
{
    public class BlogDbContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public BlogDbContext(DbContextOptions<BlogDbContext> dbContextOptions) : 
            base(dbContextOptions)
        {
            
        }
    }
}
