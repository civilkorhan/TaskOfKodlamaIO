using Business.Abstract;
using Business.Dtos.Course;
using DataAcces.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class CourseManager : ICourseService
{
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }
    Course course = new();
    public CreatedCourseResponse Add(CreatCourseRequest creatCourseRequest)
    {
        // kontrol kodları yazılır
        
        course.Name = creatCourseRequest.Name;
        course.Description = creatCourseRequest.Description;    
        _courseDal.Add(course);

        CreatedCourseResponse createdCourseResponse = new CreatedCourseResponse();
        createdCourseResponse.Id = 204;
        createdCourseResponse.Name = creatCourseRequest.Name;
        createdCourseResponse.Description=createdCourseResponse.Description;
        
        return createdCourseResponse;   

    }

    public DeletedCourseResponse Delete(DeleteCourseRequest deleteCourseRequest)
    {
        course.Name = deleteCourseRequest.Name;
        course.DeletedDate= DateTime.Now;
        _courseDal.Delete(course);

        DeletedCourseResponse deletedCourseResponse = new DeletedCourseResponse();
        deletedCourseResponse.Name=deleteCourseRequest.Name;
        deletedCourseResponse.Id =course.Id;
        deletedCourseResponse.Description=course.Description;

        return deletedCourseResponse;
    }

   

    public UpdatedCourseResponse Update(UpdateCourseRequest updateCourseRequest)
    {
        List<Course> courses = _courseDal.GetAll();
        UpdatedCourseResponse updatedCourseResponse = new UpdatedCourseResponse();  
        foreach (var course in courses)
        {
            if (course.Id == updateCourseRequest.Id)
            {
                updatedCourseResponse.Name = updateCourseRequest.Name;
                updatedCourseResponse.UpdateDate = DateTime.Now;
            }
        }
        return updatedCourseResponse;

    }

    public List<GetAllCourseResponse> GetAllCourse()
    {
        List<Course> courses= _courseDal.GetAll();
        List<GetAllCourseResponse> getAllCourseResponses = new List<GetAllCourseResponse>();
        foreach (var course in courses)
        {
            GetAllCourseResponse getAllCourseResponse = new GetAllCourseResponse();
            getAllCourseResponse.Name=course.Name;
            getAllCourseResponse.Id = course.Id;
            getAllCourseResponse.CreatedDate = DateTime.Now;
            
            getAllCourseResponses.Add(getAllCourseResponse);    
        }
        return getAllCourseResponses;   
    }
}
