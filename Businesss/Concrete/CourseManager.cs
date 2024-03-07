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

public class CourseManager : ICourseService
{
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public CreatedCourseResponse Add(CreatCourseRequest creatCourseRequest)
    {
        // kontrol kodları yazılır
        Course course = new();
        course.Name = creatCourseRequest.Name;
        course.Description = creatCourseRequest.Description;    
        _courseDal.Add(course);

        CreatedCourseResponse createdCourseResponse = new CreatedCourseResponse();
        createdCourseResponse.Id = 204;
        createdCourseResponse.Name = creatCourseRequest.Name;
        createdCourseResponse.Description=createdCourseResponse.Description;
        
        return createdCourseResponse;   

    }

    public List<CreatedCourseResponse> GetAll()
    {
        List<Course> courses=_courseDal.GetAll();
        List<CreatedCourseResponse> createdCourseResponses = new List<CreatedCourseResponse>(); 
        foreach (var course in courses) 
        { 
          CreatedCourseResponse courseResponse = new CreatedCourseResponse();
            courseResponse.Id = course.Id;
            courseResponse.Name = course.Name;
            courseResponse.Description = course.Description;

            createdCourseResponses.Add(courseResponse);
        }
        return createdCourseResponses;  
    }
}
