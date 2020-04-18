using System.Collections.Generic;
using System.Threading.Tasks;
using AngularBlog.API.Models.GenericRepository;

namespace AngularBlog.API.Models.Repository
{
    public class SubCategoryRepository: AngularBlogRepository<SubCategory>, ISubCategoryRepository
    {
        public SubCategoryRepository(DataContext context):base(context)
        {
            
        }

        public async Task<IEnumerable<SubCategory>> GetAllSubCategory()
        {
            return GetAll();
        }
    }
}