using KodlamaIo.Business.Abstracts;
using KodlamaIo.DataAcces.Abstracts;
using KodlamaIo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.Business.Concrete;

public class CourseManager : ICourseManager
{
    private ICourseDal _courseDal;
    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public void Add()
    {
        _courseDal.Add();
    }

    public void Delete()
    {
        _courseDal.Delete();
    }

    public void Update()
    {
        _courseDal.Update();
    }

    public List<Courses> GetAllCourses()
    {
        return _courseDal.GetAllCourses();
    }

}
