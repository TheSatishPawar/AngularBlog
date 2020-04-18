using System;
using DatingApp.API.Models;

namespace AngularBlog.API.Models
{
    public class Comments: IEntityBase
    {
    public int Id { get;set; }
    public int PostId { get; set; }
    public string UserName{get;set;} 
    public string PostComment { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedDate { get; set; }
    public Nullable<DateTime> ModifiedDate { get; set; }
    public Posts Post { get; set; }
        
    }
}