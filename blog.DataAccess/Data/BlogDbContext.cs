using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.web.Data
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Articles)
                .WithOne(a => a.Category)
                .HasForeignKey(a => a.CategoryID);
        }

        public DbSet<Category> categories { get; set; }
        public DbSet<Article> articles { get; set; }
    }
}
