using DataAcces.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Concrete;

public class InstructorDal : IInstructorDal
{
    List<Instructor> _instructors;
    public InstructorDal()
    {
        _instructors=new List<Instructor>();
        _instructors.Add(new Instructor { Id=1,Name="Engin",LastName="Demiroğ",CreatedDate=DateTime.Now});
        _instructors.Add(new Instructor { Id=2,Name="Halit Enes",LastName="Kalaycı",CreatedDate=DateTime.Now});
    }


    public void Add(Instructor ınstructor)
    {
        _instructors.Add(ınstructor);
    }

    public void Delete(Instructor ınstructor)
    {
        _instructors.Remove(ınstructor);
    }

    public List<Instructor> GetAll()
    {
        return _instructors;
    }

    public void Update(Instructor updtInstructor)
    {
        foreach (var instructor in _instructors)
        {
            if (instructor.Id == updtInstructor.Id)
            {
                instructor.Name = updtInstructor.Name;
                instructor.LastName = updtInstructor.LastName;
                instructor.UpdateDate = updtInstructor.CreatedDate;
            }
        }
    }
}
