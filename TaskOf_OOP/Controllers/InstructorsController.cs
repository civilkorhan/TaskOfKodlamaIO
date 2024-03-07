using Business.Abstract;
using Business.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TaskOf_OOP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorsController : ControllerBase
    {
        private readonly IInstructorService _instructorService;

        public InstructorsController(IInstructorService instructorService)
        {
            _instructorService = instructorService;
        }
        [HttpPost]
        public IActionResult Add(CreatInstructorRequest creatInstructorRequest)
        {
            CreatedInstructorResponse createdresponse = _instructorService.Add(creatInstructorRequest);
            return Ok(createdresponse);
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_instructorService.GetAll());

        }

    }

}
