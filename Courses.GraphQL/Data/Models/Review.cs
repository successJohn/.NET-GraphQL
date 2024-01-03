using System.ComponentModel.DataAnnotations;

namespace Courses.GraphQL.Data.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }

        public int Rate { get; set; }
        public string Comment { get; set; }

        public int CourseId { get; set; }

        public Course Course { get; set;}
    }
}
