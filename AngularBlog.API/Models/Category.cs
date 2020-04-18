using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using DatingApp.API.Models;

namespace AngularBlog.API.Models
{
    public class Category : IEntityBase
    {
         public int Id { get; set; }
         
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public Nullable<DateTime> ModifyDate { get; set; }
        public ICollection<SubCategory> SubCategories { get; set; }

        public Category()
        {
            SubCategories = new Collection<SubCategory>();
        }
    }
}