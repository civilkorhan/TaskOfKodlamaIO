using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Dtos.Course;

namespace Business.Abstract;

public interface ICourseService
{
    CreatedCourseResponse Add(CreatCourseRequest creatCourseRequest);
    
    DeletedCourseResponse Delete(DeleteCourseRequest deleteCourseRequest);
    UpdatedCourseResponse Update(UpdateCourseRequest updateCourseReques);
   List<GetAllCourseResponse> GetAllCourse();
}
