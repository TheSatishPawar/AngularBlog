using System.Collections.Generic;
using System.Threading.Tasks;

namespace AngularBlog.API.Models.GenericRepository
{
    public interface ISubCategoryRepository: IAngularBlogRepository<SubCategory>
    {
         Task<IEnumerable<SubCategory>> GetAllSubCategory();
    }
}