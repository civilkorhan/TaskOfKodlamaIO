using Business.Abstract;
using Business.Dtos.Inscructor;
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
            CreatedInstructorResponse createdInstructorResponse= _instructorService.Add(creatInstructorRequest);
            return Ok(createdInstructorResponse);
        }
        [HttpGet]
        public IActionResult Get()
        {
            
            return Ok(_instructorService.GetAll());

        }
        [HttpDelete]
        public IActionResult Delete(DeleteInstructorRequest deletedInstructorRequest) 
        {
            DeletedInstructorResponse deletedInstructorResponse=_instructorService.Delete(deletedInstructorRequest);
            return Ok(_instructorService.Delete(deletedInstructorRequest) ); 
        }
        [HttpPut]
        public IActionResult Update(UpdateInstructorRequest updateInstructorRequest)
        {
            UpdatedInstructorResponse updatedInstructorResponse= _instructorService.Update(updateInstructorRequest);
           return Ok( _instructorService.Update(updateInstructorRequest));
        }

    }

}
