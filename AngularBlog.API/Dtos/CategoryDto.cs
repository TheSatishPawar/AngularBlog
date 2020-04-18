using System;
using System.Collections.Generic;
using AngularBlog.API.Models;

namespace AngularBlog.API.Dtos
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }

        public ICollection<SubCategoryDto> SubCategories { get; set; }
    }
}