using KodlamaIo.Business.Abstracts;
using KodlamaIo.DataAcces.Abstracts;
using KodlamaIo.DataAcces.Concrete;
using KodlamaIo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.Business.Concrete;

public class InstructorManager : IInstructorManager
{
    private readonly IInstructorDal _instructorDal;  
    public InstructorManager(IInstructorDal instructorDal)
    {

        _instructorDal = instructorDal;

    }

    public void Add()
    {
        _instructorDal.Add();
    }

    public void Delete()
    {
        _instructorDal.Delete();
    }

    public void Update()
    {
        _instructorDal.Update();
    }

    public List<Instructor> GetAllInstructor()
    {
        return _instructorDal.GetAllInstructor();
    }

}
