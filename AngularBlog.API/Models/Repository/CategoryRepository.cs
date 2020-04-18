using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularBlog.API.Models.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace AngularBlog.API.Models.Repository
{
    public class CategoryRepository : AngularBlogRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(DataContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Category>> GetAllCategory()
        {
            return GetAll();
        }
    }
}