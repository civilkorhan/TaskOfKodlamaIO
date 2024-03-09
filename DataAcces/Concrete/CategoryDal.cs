using DataAcces.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Concrete;

public class CategoryDal : ICategoryDal
{
    List<Category> _categories;
    public CategoryDal()
    {
        _categories = new List<Category>();
        _categories.Add(new Category { Id=1,Name="Tümü",CreatedDate=DateTime.Now});
        _categories.Add(new Category { Id=2,Name="Programlama",CreatedDate=DateTime.Now});
    }
    public void Add(Category category)
    {
        _categories.Add(category);
    }

    public void Delete(Category category)
    {
        _categories.Remove(category);
    }

    public List<Category> GetAll()
    {
        return _categories; 
    }

    public void Update(Category updtCategory)
    {
       foreach (var category in _categories) 
       { 
          if(category.Id == updtCategory.Id)
            {
                category.Name = updtCategory.Name;
                category.UpdateDate = updtCategory.CreatedDate;
                
            }
       }
    }
}
