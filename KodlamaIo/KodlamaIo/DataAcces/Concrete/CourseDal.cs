using KodlamaIo.DataAcces.Abstracts;
using KodlamaIo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.DataAcces.Concrete;

public class CourseDal : ICourseDal
{
    List<Courses> listCourses;
    public CourseDal()
    {
        Courses course1 = new Courses();
        course1.CourseId = 1;
        course1.CourseName = "Senior Yazılım Geliştirici Yetiştirme Kampı (.NET)";
        course1.CourseInstructor = "Engin DemirOg";
        course1.CourseDescription = "";
        course1.CoursePrice = 0;
        course1.Progress = 0;

        Courses course2 = new Courses();
        course2.CourseId = 1;
        course2.CourseName = "Programlamaya Giriş İçin Temel Kurs";
        course2.CourseInstructor = "Engin DemirOg";
        course2.CourseDescription = "PYTHON, JAVA, C# gibi tüm programlama dilleri için temel programlama mantığını anlaşılır örneklerle öğrenin.";
        course2.CoursePrice = 0;
        course2.Progress = 25;

        Courses course3 = new Courses();
        course3.CourseId = 1;
        course3.CourseName = "(2023) Yazılım Geliştirici Yetiştirme Kampı - Python & Selenium";
        course3.CourseInstructor = "Halit Enes Kalaycı";
        course3.CourseDescription = "Python & Selenium Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.";
        course3.CoursePrice = 0;
        course3.Progress = 25;

        
        listCourses= new List<Courses>() {course1,course2,course3 };
    }

    public void Add()
    {
        Console.WriteLine("Kurs Eklendi");
    }

    public void Delete()
    {
        Console.WriteLine("Kurs Silindi");
    }

    public void Update()
    {
        Console.WriteLine("Kurs Güncellendi");
    }

    public List<Courses> GetAllCourses()
    {
        return listCourses;
    }


}
