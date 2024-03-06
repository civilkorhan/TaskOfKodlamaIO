using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract;

public interface ICategoryService
{
    CreatedCategoryResponse Add(CreatCategoryRequest category);
    List<CreatedCategoryResponse> GetAll();
}
