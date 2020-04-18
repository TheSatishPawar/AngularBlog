using Microsoft.AspNetCore.Mvc;

namespace AngularBlog.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValueController : ControllerBase
    {
         [HttpGet]
        public IActionResult Get()
        {
           // var result = _iCategoryRepository.GetAll();
          // AdminBO adminBO = new AdminBO();
          // var result = adminBO.GetCustomerList();
           return Ok("hi");
        }
    }
}