using Business.Dtos.Inscructor;
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
    List<GetAllInstructorResponse> GetAll();
    DeletedInstructorResponse Delete(DeleteInstructorRequest  deleteInstructorRequest);
    UpdatedInstructorResponse Update(UpdateInstructorRequest updateInstructorRequest);
    
}
