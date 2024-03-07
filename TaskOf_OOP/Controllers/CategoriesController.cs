using Business.Abstract;
using Business.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TaskOf_OOP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost]
        public IActionResult Add(CreatCategoryRequest creatCategoryRequest)
        {
            CreatedCategoryResponse createdCategoryResponse= _categoryService.Add(creatCategoryRequest);
            return Ok(createdCategoryResponse);
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_categoryService.GetAll());

        }
    }
}
