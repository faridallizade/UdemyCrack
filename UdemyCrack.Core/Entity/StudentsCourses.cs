using UdemyCrack.Core.Entity.Common;

namespace UdemyCrack.Models
{
    public class StudentsCourses:BaseAuditable
    {
        public Student Student { get; set; }
        public Course Course { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set;}
    }
}
