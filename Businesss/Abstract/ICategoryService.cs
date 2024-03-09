using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Dtos.Category;

namespace Business.Abstract;

public interface ICategoryService
{
    CreatedCategoryResponse Add(CreatCategoryRequest category);
    
    DeletedCategoryResponse Delete(DeleteCategoryRequest deleteCategoryRequest);
    UpdatedCategoryResponse Update(UpdateCategoryRequest updateCategoryRequest);
    List<GetAllCategoryResponse> GetAllCategories();
}
