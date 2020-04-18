using System.Collections.Generic;
using System.Threading.Tasks;

namespace AngularBlog.API.Models.GenericRepository
{
    public interface  ICategoryRepository : IAngularBlogRepository<Category>
    {
        Task<IEnumerable<Category>> GetAllCategory();
    }
}