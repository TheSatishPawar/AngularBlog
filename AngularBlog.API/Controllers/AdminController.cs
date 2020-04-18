using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularBlog.API.Models.GenericRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AutoMapper;
using AngularBlog.API.Dtos;
using AngularBlog.API.Models;
using Microsoft.EntityFrameworkCore;

namespace AngularBlog.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly ICategoryRepository _iCategoryRepository;
        private readonly ISubCategoryRepository _iSubCategoryRepository;
        private readonly IMapper _mapper;

        public AdminController(ICategoryRepository iCategoryRepository, IMapper mapper, ISubCategoryRepository iSubCategoryRepository)
        {
            _iCategoryRepository = iCategoryRepository;
            _mapper = mapper;
            _iSubCategoryRepository = iSubCategoryRepository;
        }

        [HttpGet]
        [Route("GetCategoryList")]
        public async Task<IActionResult> GetCategoryList()
        {
            var result = _mapper.Map<IEnumerable<CategoryDto>>(_iCategoryRepository.GetAll().Include(x=>x.SubCategories));
            return Ok(result);
        }

        [HttpPost]
        [Route("AddCategory")]
        public async Task<IActionResult> PostCategory([FromBody] CategoryDto categoryDto)
        {
            var category = _mapper.Map<Category>(categoryDto);
            category.CreatedDate = DateTime.UtcNow;
            await _iCategoryRepository.Create(category);
            if (await _iCategoryRepository.SaveAll())
                return Ok(_mapper.Map<CategoryDto>(category));

            throw new Exception("Error adding the category");

        }

        [HttpGet]
        [Route("GetSubCategoryList")]
        public async Task<IActionResult> GetSubCategoryList()
        {
            var result = _mapper.Map<IEnumerable<SubCategoryDto>>(_iSubCategoryRepository.GetAll());
            return Ok(result);
        }

        [HttpPost]
        [Route("AddSubCategory")]
        public async Task<IActionResult> PostSubCategory([FromBody] SubCategoryDto subCategoryDto)
        {
            var subCategory = _mapper.Map<SubCategory>(subCategoryDto);
            subCategory.CreatedDate = DateTime.UtcNow;
            await _iSubCategoryRepository.Create(subCategory);
            if (await _iSubCategoryRepository.SaveAll())
                return Ok(_mapper.Map<SubCategoryDto>(subCategory));

            throw new Exception("Error adding the category");

        }
    }
}
