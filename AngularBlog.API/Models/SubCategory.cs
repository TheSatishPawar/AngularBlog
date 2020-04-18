using System;
using DatingApp.API.Models;

namespace AngularBlog.API.Models
{
    public class SubCategory : IEntityBase
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public Nullable<DateTime> ModifyDate { get; set; }

        public Category Category { get; set; }
    }
}