using System.ComponentModel.DataAnnotations;

namespace logreg.Models
{
    public abstract class BaseEntity {}
    public class Reg: BaseEntity
    {
        [Required]
        [MinLength(2)]
        [RegularExpression("[a-zA-Z]*")]
        public string fname { get; set; }
        [Required]
        [MinLength(2)]
        [RegularExpression("[a-zA-Z]*")]
        public string lname { get; set; }
        [Required]
        [Compare(nameof(pw))]
        [DataType(DataType.Password)]
        public string cpw { get; set; }
        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string pw { get; set; }
    }

    public class Log: BaseEntity
    {
        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string pw { get; set; }
    }

    public class User: BaseEntity
    {
        public Reg regdetails { get; set; } 
        public Log logdetails { get; set; }
    }
} 