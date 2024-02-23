using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.Entities;

public class Courses
{
    public int CourseId { get; set; }
    public string CourseName { get; set; }
    public string CourseDescription { get; set; }
    public string CourseInstructor { get; set; }
    public int CoursePrice {  get; set; }
    public int Progress { get; set; }

}
