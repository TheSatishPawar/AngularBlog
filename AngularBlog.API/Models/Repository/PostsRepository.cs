using AngularBlog.API.Models.GenericRepository;

namespace AngularBlog.API.Models.Repository
{
    public class PostsRepository : AngularBlogRepository<Posts>, IPostsRepository
    {
        public PostsRepository(DataContext context) : base(context)
        {
        }
    }
}