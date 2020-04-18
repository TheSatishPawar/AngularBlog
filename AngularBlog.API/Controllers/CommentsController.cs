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
    public class CommentsController : ControllerBase
    {
        private readonly ICommentsRepository _iCommentsRepository;
        private readonly IMapper _mapper;

        public CommentsController(ICommentsRepository iCommentsRepository, IMapper mapper)
        {
            _iCommentsRepository = iCommentsRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetCommentsList")]
        public async Task<IActionResult> GetCommentsList()
        {
            var result = _mapper.Map<IEnumerable<CommentsDto>>(_iCommentsRepository.GetAll());
            return Ok(result);
        }

        [HttpGet]
        [Route("GetCommentById")]
        public async Task<IActionResult> GetCommentById(int commentId)
        {
            var result = _mapper.Map<PostDetailDto>(_iCommentsRepository.GetById(commentId));
            if (result == null)
                return BadRequest("Post not found");

            return Ok(result);
        }

        [HttpPost]
        [Route("AddComment")]
        public async Task<IActionResult> AddComment([FromBody] CommentsDto newCommentDto)
        {
            var comment = _mapper.Map<Comments>(newCommentDto);
            comment.CreatedDate = DateTime.UtcNow;
            await _iCommentsRepository.Create(comment);
            if (await _iCommentsRepository.SaveAll())
                return Ok(_mapper.Map<CommentsDto>(comment));

            throw new Exception("Error adding the category");

        }

    }
}