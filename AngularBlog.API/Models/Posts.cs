using System;
using System.Collections.Generic;
using DatingApp.API.Models;

namespace AngularBlog.API.Models
{
    public class Posts : IEntityBase
    {
        public int Id { get;set; }
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public string PostHeader { get; set; }
        public string PostBody  {get;set;}
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public Nullable<DateTime> ModifiedDate { get; set; }
        public Category Category {get;set;}
        public SubCategory SubCategory{get;set;} 
        public ICollection<Comments> Comments { get; set; }
    }
}