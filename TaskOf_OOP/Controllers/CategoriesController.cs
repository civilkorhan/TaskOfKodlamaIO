using Business.Abstract;
using Business.Dtos.Category;
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
            return Ok(_categoryService.GetAllCategories());

        }
        [HttpDelete] 
        public IActionResult Delete(DeleteCategoryRequest deleteCategoryRequest)
        {
            DeletedCategoryResponse deletedCategoryResponse = _categoryService.Delete(deleteCategoryRequest);
            return Ok(deletedCategoryResponse);
        }
        [HttpPut]
        public IActionResult Update(UpdateCategoryRequest updateCategoryRequest) 
        {  UpdatedCategoryResponse updatedCategoryResponse=_categoryService.Update(updateCategoryRequest);
            return Ok(updatedCategoryResponse);
        }
    }
}
