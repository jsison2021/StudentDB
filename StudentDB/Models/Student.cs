using System.ComponentModel.DataAnnotations;

namespace StudentDB.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        public string picture { get; set; }
        public float GPA { get; set; }
        public float Grade { get; set; }

    }
}
