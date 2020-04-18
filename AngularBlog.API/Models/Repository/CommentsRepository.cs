using AngularBlog.API.Models.GenericRepository;

namespace AngularBlog.API.Models.Repository
{
    public class CommentsRepository : AngularBlogRepository<Comments>, ICommentsRepository
    {
        public CommentsRepository(DataContext context) : base(context)
        {
        }
    }
}