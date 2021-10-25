using PreAceleracion.Entities;
using Microsoft.EntityFrameworkCore;

namespace PreAceleracion.Context
{
    public class BlogContext : DbContext
    {
        private const string Schema = "blog";

        public BlogContext(DbContextOptions options) : base(options) {
        
        }

        public DbSet<Users> Users { get; set; } = null!;
        public DbSet<Posts> Posts { get; set; } = null!;
        public DbSet<Comments> Comments { get; set; } = null!;
    }


}
