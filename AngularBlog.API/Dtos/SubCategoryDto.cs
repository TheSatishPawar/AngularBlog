using System;

namespace AngularBlog.API.Dtos
{
    public class SubCategoryDto
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        //public DateTime ModifyDate { get; set; }
    }
}