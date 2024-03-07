using Business.Abstract;
using Business.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TaskOf_OOP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_courseService.GetAll());
        }
        [HttpPost]
        public IActionResult Add(CreatCourseRequest creatCourseRequest)
        {
            CreatedCourseResponse createdCourseResponse = _courseService.Add(creatCourseRequest);
                return Ok(createdCourseResponse);   
        }
    }
}
