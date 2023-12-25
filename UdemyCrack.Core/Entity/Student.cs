using UdemyCrack.Core.Entity.Common;

namespace UdemyCrack.Models
{
    public class Student:BaseAuditable
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public ICollection<StudentsCourses> StudentsCourses { get; set; }
    }
}
