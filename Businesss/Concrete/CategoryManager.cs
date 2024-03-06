using Business.Abstract;
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

    public CreatedCategoryResponse Add(CreatCategoryRequest creatCategoryRequest)
    {
        // kontrol kodları yazılır 
        Category category = new();
        category.Name = creatCategoryRequest.Name;
        category.CreatedDate = DateTime.Now;
        _categoryDal.Add(category);    

        CreatedCategoryResponse createdCategoryResponse = new CreatedCategoryResponse();
        createdCategoryResponse.Id = 3;
        createdCategoryResponse.Name = category.Name;
        return createdCategoryResponse; 
    
    }

    public List<CreatedCategoryResponse> GetAll()
    {
        List<Category> categoryList = _categoryDal.GetAll();
        List<CreatedCategoryResponse> createdCategoryResponses = new List<CreatedCategoryResponse>();
        foreach (var category in categoryList)
        {
            CreatedCategoryResponse createdCategoryResponse = new CreatedCategoryResponse();
            createdCategoryResponse.Id = category.Id;
            createdCategoryResponse.Name = category.Name;

            createdCategoryResponses.Add(createdCategoryResponse);  // ekledik
        }
        return createdCategoryResponses;    
    }
}
