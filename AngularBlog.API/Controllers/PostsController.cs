using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AngularBlog.API.Dtos;
using AngularBlog.API.Models;
using AngularBlog.API.Models.GenericRepository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AngularBlog.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostsController: ControllerBase
    {
         private readonly IPostsRepository _iPostsRepository;
        private readonly IMapper _mapper;

        public PostsController(IPostsRepository iPostsRepository, IMapper mapper)
        {
            _iPostsRepository = iPostsRepository;
            _mapper = mapper;           
        }

         [HttpGet]
        [Route("GetPostsList")]
        public async Task<IActionResult> GetPostsList()
        {
            var result = _mapper.Map<IEnumerable<PostsListDto>>(_iPostsRepository.GetAll());
            return Ok(result);
        }

         [HttpGet]
        [Route("GetPostsById")]
        public async Task<IActionResult> GetPostsById(int postId)
        {
            var result = _mapper.Map<PostDetailDto>(_iPostsRepository.GetById(postId));
            if (result == null)
                return BadRequest("Post not found");

            return Ok(result);
        }

        [HttpPost]
        [Route("AddPost")]
        public async Task<IActionResult> AddPost([FromBody] NewPostDto newPostDto)
        {
            var post = _mapper.Map<Posts>(newPostDto);
            post.CreatedDate = DateTime.UtcNow;
            await _iPostsRepository.Create(post);
            if (await _iPostsRepository.SaveAll())
                return Ok(_mapper.Map<NewPostDto>(post));

            throw new Exception("Error adding the category");

        }
    }
}