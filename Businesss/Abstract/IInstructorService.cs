using Business.Dtos;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract;

public interface IInstructorService
{
    CreatedInstructorResponse Add(CreatInstructorRequest creatInstructorRequest);
    List<CreatedInstructorResponse> GetAll();
    CreatedInstructorResponse Delete(Instructor ınstructor);
    CreatedInstructorResponse Update(Instructor ınstructor);
    
}
