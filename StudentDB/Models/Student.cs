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

        [Required]
        public string Grade { get; set; }

        [Required]
        public float GPA { get; set; }
     

    }
}
