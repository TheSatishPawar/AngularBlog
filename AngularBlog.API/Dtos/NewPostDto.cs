namespace AngularBlog.API.Dtos
{
    public class NewPostDto
    {
         public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public string PostHeader { get; set; }
        public string PostBody { get; set; }
    }
}