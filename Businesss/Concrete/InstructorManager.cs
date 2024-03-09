using Business.Abstract;
using Business.Dtos.Inscructor;
using DataAcces.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreatedInstructorResponse = Business.Dtos.Inscructor.CreatedInstructorResponse;

namespace Business.Concrete;

public class InstructorManager : IInstructorService
{
    private readonly IInstructorDal _instructorDal;

    public InstructorManager(IInstructorDal instructorDal)
    {
        _instructorDal = instructorDal;

    }
    Instructor instructor = new();
    public CreatedInstructorResponse Add(CreatInstructorRequest creatInstructorRequest)
    {
       
        instructor.Name = creatInstructorRequest.Name;
        instructor.LastName = creatInstructorRequest.LastName;  
        instructor.CreatedDate=DateTime.Now;

        _instructorDal.Add(instructor);

        CreatedInstructorResponse createdInstructorResponse = new CreatedInstructorResponse();
        createdInstructorResponse.Name=creatInstructorRequest.Name; 
        createdInstructorResponse.LastName=creatInstructorRequest.LastName;
        createdInstructorResponse.Id = 11;
        createdInstructorResponse.CreatedDate=DateTime.Now;

        return createdInstructorResponse;   

        
    }

   

    public DeletedInstructorResponse Delete(DeleteInstructorRequest deleteInstructorRequest)
    {
        instructor.Name = deleteInstructorRequest.Name;
        instructor.LastName = deleteInstructorRequest.LastName;
        instructor.DeletedDate=DateTime.Now;
        _instructorDal.Delete(instructor);
        DeletedInstructorResponse deletedInstructorResponse = new DeletedInstructorResponse();
        deletedInstructorResponse.Name=deleteInstructorRequest.Name;
        deletedInstructorResponse.LastName=deleteInstructorRequest.LastName;
        deletedInstructorResponse.Id=instructor.Id;
        return deletedInstructorResponse;
        
    }

    public List<GetAllInstructorResponse> GetAll()
    {
        List<Instructor> ınstructors= _instructorDal.GetAll();
        List<GetAllInstructorResponse> createdInstructorResponses= new List<GetAllInstructorResponse>();
        foreach (var instructor in ınstructors)
        {
            GetAllInstructorResponse createdInstructorResponse= new GetAllInstructorResponse();
            createdInstructorResponse.Id=instructor.Id;
            createdInstructorResponse.Name = instructor.Name;
            createdInstructorResponse.LastName = instructor.LastName;
            createdInstructorResponse.CreatedDate = instructor.CreatedDate;
            
            createdInstructorResponses.Add(createdInstructorResponse);
            
        }
        return createdInstructorResponses;  
    }

    

    public UpdatedInstructorResponse Update(UpdateInstructorRequest updateInstructorRequest)
    {
        List<Instructor> instructors = _instructorDal.GetAll();
       
        foreach (var instructor in instructors)
        {
            if (instructor.Id == updateInstructorRequest.Id)
            {
                instructor.Name = updateInstructorRequest.Name;
                instructor.LastName=updateInstructorRequest.LastName;
                instructor.UpdateDate = DateTime.Now;
            }

        }
        UpdatedInstructorResponse updatedInstructorResponse = new UpdatedInstructorResponse();
        updatedInstructorResponse.Name=updateInstructorRequest.Name;
        updatedInstructorResponse.LastName=updateInstructorRequest.LastName;
        updatedInstructorResponse.Id=updateInstructorRequest.Id;    

        return updatedInstructorResponse;


    }

    
}
