using System.ComponentModel.DataAnnotations;

namespace MathProject.Models
{
    public class NumberInfo
    {
        [Key]  // Primary Key for Database
        public int Id { get; set; }

        [Required]
        public int Number { get; set; }
        public bool IsPrime { get; set; }
        public bool IsPerfect { get; set; }
        public List<string> Properties { get; set; }  // e.g., ["armstrong", "odd"]
        public int DigitSum { get; set; }  // Sum of digits
        public string FunFact { get; set; }
    }
}
