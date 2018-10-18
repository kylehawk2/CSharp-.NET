using System.ComponentModel.DataAnnotations;

namespace Week4_Lecture1
{
    public class Dog
    {
        [Required]
        [RegularExpression("^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$")]
        [MinLength(2)]
        [MaxLength(25)]
        public string Name { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(25)]
        public string Breed { get; set; }
        [Range(0, 150)]
        public double Weight { get; set; }
        [EmailAddress]
        public string OwnerEmail { get; set; }
    }
}