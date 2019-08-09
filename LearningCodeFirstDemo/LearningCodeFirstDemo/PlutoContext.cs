using System.Data.Entity;

namespace LearningCodeFirstDemo
{
    public class PlutoContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Author> Authors { get; set; }

        public PlutoContext()
            :base ("name=DefaultConnection")
        {
            
        }
    }
}