using Microsoft.EntityFrameworkCore;

namespace AngularBlog.API.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Posts> Posts{get;set;}
        public DbSet<Comments> Comments{get;set;}
    }
}