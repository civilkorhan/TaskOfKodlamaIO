using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Abstract;

public interface IInstructorDal
{
    void Add(Instructor ınstructor);
    void Delete(Instructor ınstructor);
    void Update(Instructor ınstructor);
    List<Instructor> GetAll();
}
