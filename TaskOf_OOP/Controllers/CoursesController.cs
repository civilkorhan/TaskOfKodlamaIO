using Business.Abstract;
using Business.Dtos.Category;
using Business.Dtos.Course;
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
            return Ok(_courseService.GetAllCourse());
        }
        [HttpPost]
        public IActionResult Add(CreatCourseRequest creatCourseRequest)
        {
            CreatedCourseResponse createdCourseResponse = _courseService.Add(creatCourseRequest);
                return Ok(createdCourseResponse);   
        }
        [HttpDelete]
        public IActionResult Delete(DeleteCourseRequest deleteCourseRequest)
        {
           DeletedCourseResponse deletedCourseResponse = _courseService.Delete(deleteCourseRequest);
            return Ok(deleteCourseRequest);
        }
        [HttpPut]
        public IActionResult Update(UpdateCourseRequest updateCourseRequest)
        {
            UpdatedCourseResponse updatedCourseResponse = _courseService.Update(updateCourseRequest);
            return Ok(updateCourseRequest);
        }
    }
}
