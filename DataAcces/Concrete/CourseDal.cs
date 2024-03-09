using DataAcces.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Concrete;

public class CourseDal : ICourseDal
{
    List<Course> _courses;
    public CourseDal()
    {
         _courses = new List<Course>(); 
         _courses.Add(new Course { Id=101,Name= "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)",CreatedDate=DateTime.Now });
         _courses.Add(new Course { Id=102,Name= "Yazılım Geliştirici Yetiştirme Kampı (C# + ANGULAR)", CreatedDate=DateTime.Now });
         _courses.Add(new Course { Id=103,Name= "Yazılım Geliştirici Yetiştirme Kampı (JAVA & REACT)", CreatedDate=DateTime.Now });
         _courses.Add(new Course { Id=104,Name= "Yazılım Geliştirici Yetiştirme Kampı (JavaScript)", CreatedDate=DateTime.Now });
         _courses.Add(new Course { Id=105,Name= "Senior Yazılım Geliştirici Yetiştirme Kampı", CreatedDate=DateTime.Now });
         _courses.Add(new Course { Id=106,Name= "(2022) Yazılım Geliştirici Yetiştirme Kampı (JAVA)\r\n", CreatedDate=DateTime.Now });
         _courses.Add(new Course { Id=107,Name= "(2023) Yazılım Geliştirici Yetiştirme Kampı (Python & Selenium)\r\n", CreatedDate=DateTime.Now });
         _courses.Add(new Course { Id=108,Name= "Programlamaya Giriş için Temel Kurs", CreatedDate=DateTime.Now });
    }
    public void Add(Course course)
    {
        _courses.Add(course);
    }

    public void Delete(Course course)
    {
        _courses.Remove(course);
    }

    public List<Course> GetAll()
    {
        return _courses;    
    }

    public void Update(Course updtCourse)
    {
        foreach (var course in _courses)
        {
            if (updtCourse.Id ==course.Id)
            {
                course.Name = updtCourse.Name;
                course.Description = updtCourse.Description;
                course.UpdateDate = updtCourse.CreatedDate;
            }
        }
    }
}
