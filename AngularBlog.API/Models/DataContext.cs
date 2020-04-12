using Microsoft.EntityFrameworkCore;

namespace AngularBlog.API.Models
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options){            
        }

        public DbSet<Category> Categories {get; set;}
    }
}