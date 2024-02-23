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

            CourseManager courseManager = new CourseManager(new CourseDal());
            List<Courses> courses=courseManager.GetAllCourses();

            foreach (Courses course in courses)
            {
                Console.WriteLine(course.CourseName);
            }

            Console.WriteLine("");
            Console.WriteLine("");


            InstructorManager instructorManager = new InstructorManager(new InstructorDal());
            List<Instructor> ins = instructorManager.GetAllInstructor();

            foreach (var item in ins)
            {
                Console.WriteLine(item.InstructorName);
            }

        }
    }
}
