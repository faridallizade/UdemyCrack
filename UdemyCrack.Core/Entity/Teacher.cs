using UdemyCrack.Core.Entity.Common;

namespace UdemyCrack.Models
{
    public class Teacher:BaseAuditable
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public ICollection<Course> Course { get; set; }
    }
}
