using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Dtos;

namespace Business.Abstract;

public interface ICourseService
{
    CreatedCourseResponse Add(CreatCourseRequest creatCourseRequest);
    List<CreatedCourseResponse>GetAll();
}
