using Business.Abstract;
using Business.Dtos.Category;
using DataAcces.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class CategoryManager : ICategoryService
{
    private readonly ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }
    Category category = new();
    public CreatedCategoryResponse Add(CreatCategoryRequest creatCategoryRequest)
    {
        // kontrol kodları yazılır 
       
        category.Name = creatCategoryRequest.Name;
        category.CreatedDate = DateTime.Now;
        _categoryDal.Add(category);    

        CreatedCategoryResponse createdCategoryResponse = new CreatedCategoryResponse();
        createdCategoryResponse.Id = 3;
        createdCategoryResponse.Name = category.Name;
        return createdCategoryResponse; 
    
    }

    public DeletedCategoryResponse Delete(DeleteCategoryRequest deleteCategoryRequest)
    {
        category.Name = deleteCategoryRequest.Name;
        category.DeletedDate = DateTime.Now;
        _categoryDal.Delete(category);
        
        DeletedCategoryResponse deletedCategoryResponse = new DeletedCategoryResponse();
        deletedCategoryResponse.Id=category.Id;
        deletedCategoryResponse.Name = category.Name;
        return deletedCategoryResponse;

    }

    

    public UpdatedCategoryResponse Update(UpdateCategoryRequest updateCategoryRequest)
    {   List<Category>categories = _categoryDal.GetAll();
        foreach (var category in categories)
        {
            if ( category.Id==updateCategoryRequest.Id)
            {
                category.Name = updateCategoryRequest.Name;
                category.UpdateDate = DateTime.Now;
                
            }
        }
        UpdatedCategoryResponse updatedCategoryResponse = new UpdatedCategoryResponse();
        updatedCategoryResponse.Id=updateCategoryRequest.Id;    
        updatedCategoryResponse.Name=updateCategoryRequest.Name;
        updatedCategoryResponse.UpdateDate=DateTime.Now;

        return updatedCategoryResponse;
    }

   

    public List<GetAllCategoryResponse> GetAllCategories()
    {
        List<Category> categoryList = _categoryDal.GetAll();
       List<GetAllCategoryResponse> allCategories = new List<GetAllCategoryResponse>();
        foreach (var category in categoryList)
        {
            GetAllCategoryResponse allCategoryResponse = new GetAllCategoryResponse();
            allCategoryResponse.Id = category.Id;
            allCategoryResponse.Name = category.Name;

            allCategories.Add(allCategoryResponse);  // ekledik
        }
        return allCategories;
    }
}
