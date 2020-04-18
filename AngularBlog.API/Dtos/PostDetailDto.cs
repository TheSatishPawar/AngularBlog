using System;
using System.Collections.Generic;

namespace AngularBlog.API.Dtos
{
    public class PostDetailDto
    {
        public PostDetailDto(int id, int categoryId, int subCategoryId, string postHeader, bool isActive, DateTime createdDate, CategoryDto category, SubCategoryDto subCategory)
        {
            this.Id = id;
            this.CategoryId = categoryId;
            this.SubCategoryId = subCategoryId;
            this.PostHeader = postHeader;
            this.IsActive = isActive;
            this.CreatedDate = createdDate;
            this.Category = category;
            this.SubCategory = subCategory;

        }
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public string PostHeader { get; set; }
        public string PostBody { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public CategoryDto Category { get; set; }
        public SubCategoryDto SubCategory { get; set; }
        public ICollection<CommentsDto> Comments { get; set; }
    }
}