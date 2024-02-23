using KodlamaIo.Business.Concrete;
using KodlamaIo.DataAcces.Concrete;
using KodlamaIo.Entities;

namespace KodlamaIo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            CategoryDal categoryDal = new CategoryDal();
            List<Category> categories = categoryDal.GetAllCategory();

            foreach (Category category in categories)
            {
                Console.WriteLine(category.CategoryName);
            }
            */

            Console.WriteLine("Courses");
            Console.WriteLine("");

            CourseManager courseManager1 = new CourseManager(new CourseDal());
            List<Courses> courses=courseManager1.GetAllCourses();

            foreach (Courses cour in courses)
            {
                Console.WriteLine(cour.CourseName);
            }

            Console.WriteLine("");
            Console.WriteLine("Instructions");
            Console.WriteLine("");


            InstructorManager instructorManager1 = new InstructorManager(new InstructorDal());
            List<Instructor> ins = instructorManager1.GetAllInstructor();

            foreach (var item in ins)
            {
                Console.WriteLine(item.InstructorName);
            }

            Console.WriteLine("");
            Console.WriteLine("Categories");
            Console.WriteLine("");


            CateogryManager categoryManager1 = new(new CategoryDal());
            List<Category> category=categoryManager1.GetAllCategory();
            foreach (var item in category)
            {
                Console.WriteLine(item.CategoryName);
            }




            Console.WriteLine("");
            Console.WriteLine("Eğitmen Eklenir");
            Console.WriteLine("");




            Instructor instructor1 = new Instructor();
            instructor1.InstructorId = 4;
            instructor1.InstructorName = "Ali Yıldız";

            instructorManager1.Add(instructor1);

            List<Instructor> ins2 = instructorManager1.GetAllInstructor();

            foreach (var item in ins2)
            {
                Console.WriteLine(item.InstructorName);
            }






            Console.WriteLine("");
            Console.WriteLine("Kategori Eklenir");
            Console.WriteLine("");
            



            Category category1= new Category();
            category1.CategoryId = 5;
            category1.CategoryName = "Algoritma";


            categoryManager1.Add(category1);
            List<Category> categories2 = categoryManager1.GetAllCategory();
            foreach (var item in categories2)
            {
                Console.WriteLine(item.CategoryName);
            }



            Console.WriteLine("");
            Console.WriteLine("Kurse Eklenir");
            Console.WriteLine("");

            Courses course1 = new Courses();
            course1.CourseId = 7;
            course1.CourseName = "2024 Yazılım Geliştirici Yerleştirme Kampı (C#)";
            course1.CourseInstructor = "Engin DemirOg";
            course1.CourseDescription = "";
            course1.CoursePrice = 0;
            course1.Progress = 70;

            courseManager1.Add(course1);
            List<Courses> courses1= courseManager1.GetAllCourses();

            foreach (var item in courses1)
            {
                Console.WriteLine(item.CourseName);
            }

        }
    }
}
