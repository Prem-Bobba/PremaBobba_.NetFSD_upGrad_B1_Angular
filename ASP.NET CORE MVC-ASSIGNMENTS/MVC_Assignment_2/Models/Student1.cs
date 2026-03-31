using System.ComponentModel.DataAnnotations;

namespace MVC_Assignment_2.Models
{
    public class Student1
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string ? Name { get; set; }

        [Range(18, 60)]
        public int Age { get; set; }

        [EmailAddress]
        public string ? Email { get; set; }
    }
}
