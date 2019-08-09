using System.Collections.Generic;

namespace LearningCodeFirstDemo
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Course> Course { get; set; }
    }
}