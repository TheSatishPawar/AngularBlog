using AngularBlog.API.Dtos;
using AngularBlog.API.Models;
using AutoMapper;

namespace AngularBlog.API.Helpers
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Category,CategoryDto>().ReverseMap();
            CreateMap<SubCategory,SubCategoryDto>().ReverseMap();
        }
    }
}