using KodlamaIo.DataAcces.Abstracts;
using KodlamaIo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.DataAcces.Concrete;

public class InstructorDal : IInstructorDal
{
    List<Instructor> listInstructors;
    public InstructorDal()
    {
        Instructor instructor1 = new Instructor();
        instructor1.InstructorId = 1;
        instructor1.InstructorName = "Tümü";

        Instructor instructor2 = new Instructor();
        instructor2.InstructorId = 2;
        instructor2.InstructorName = "Engin DemirOg";

        Instructor instructor3 = new Instructor();
        instructor3.InstructorId = 3;
        instructor3.InstructorName = "Halit Enes Kalaycı";


        listInstructors = new List<Instructor>() { instructor1,instructor2,instructor3};

    }


    public void Add(Instructor instructor)
    {
        listInstructors.Add(instructor);
    }

    public void Delete()
    {
        Console.WriteLine("Eğitmen Silindi");
    }

    public void Update()
    {
        Console.WriteLine("Eğitmen Güncellendi");
    }


    public List<Instructor> GetAllInstructor()
    {
        return listInstructors;
    }
}
