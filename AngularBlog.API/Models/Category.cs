using System;
using System.ComponentModel.DataAnnotations;

namespace AngularBlog.API.Models
{
    public class Category
    {
        public int Id {get;set;}

        [Required]
        [MaxLength(200)]
        public string Name {get;set;}
        public bool IsActive {get;set;}
        public DateTime CreatedDate{get;set;}
    }
}