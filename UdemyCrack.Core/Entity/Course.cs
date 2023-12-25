using UdemyCrack.Core.Entity.Common;

namespace UdemyCrack.Models
{
    public class Course:BaseAuditable
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int TeacherId { get; set; }
        public ICollection<StudentsCourses> StudentsCourses { get; set; }
        public Teacher Teacher { get; set; }
    }
}
