using System;

namespace AngularBlog.API.Dtos
{
    public class PostsListDto
    {
        public int Id { get; set; }
        public string PostHeader { get; set; }
        public string PostBody { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public Nullable<DateTime> ModifiedDate { get; set; }
        public CategoryDto Category { get; set; }
        public SubCategoryDto SubCategory { get; set; }

    }
}