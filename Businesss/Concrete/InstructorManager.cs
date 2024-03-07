using Business.Abstract;
using Business.Dtos;
using DataAcces.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class InstructorManager : IInstructorService
{
    private readonly IInstructorDal _instructorDal;

    public InstructorManager(IInstructorDal instructorDal)
    {
        _instructorDal = instructorDal;

    }

    public CreatedInstructorResponse Add(CreatInstructorRequest creatInstructorRequest)
    {
        Instructor instructor = new();
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

    public CreatedInstructorResponse Delete(Instructor ınstructor)
    {
        throw new NotImplementedException();
    }

    public List<CreatedInstructorResponse> GetAll()
    {
        List<Instructor> ınstructors= _instructorDal.GetAll();
        List<CreatedInstructorResponse> createdInstructorResponses= new List<CreatedInstructorResponse>();
        foreach (var instructor in ınstructors)
        {
            CreatedInstructorResponse createdInstructorResponse= new CreatedInstructorResponse();
            createdInstructorResponse.Id=instructor.Id;
            createdInstructorResponse.Name = instructor.Name;
            createdInstructorResponse.LastName = instructor.LastName;
            createdInstructorResponse.CreatedDate = instructor.CreatedDate;
            
            createdInstructorResponses.Add(createdInstructorResponse);
            
        }
        return createdInstructorResponses;  
    }

    public CreatedInstructorResponse Update(Instructor ınstructor)
    {
        throw new NotImplementedException();
    }
}
