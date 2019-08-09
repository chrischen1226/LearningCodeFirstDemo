using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LearningCodeFirstDemo
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public CourseLevel Level { get; set; }
        public float FullPrice { get; set; }
        public Author Author { get; set; }
    }

    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Course> Course { get; set; }
    }

    public enum CourseLevel
    {
        Beinner=1,
        Intermediate=2,
        Advanced=3
    }

    public class PlutoContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Author> Authors { get; set; }

        public PlutoContext()
        :base ("name=DefaultConnection")
        {
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
