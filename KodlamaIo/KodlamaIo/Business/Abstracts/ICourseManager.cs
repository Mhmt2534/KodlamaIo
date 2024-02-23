using KodlamaIo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.Business.Abstracts;

public interface ICourseManager
{
    public List<Courses> GetAllCourses();
    public void Add();
    public void Update();
    public void Delete();
}
