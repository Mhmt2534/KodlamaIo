using KodlamaIo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.DataAcces.Abstracts;

public interface ICourseDal
{
    public void Add();
    public void Delete();
    List<Courses> GetAllCourses();
    public void Update();
}
