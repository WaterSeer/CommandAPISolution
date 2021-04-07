using System.ComponentModel.DataAnnotations;


namespace CommandAPI.Models
{
    public class Command
    {
        [Key] //primary key
        [Required] //not be null
        public int Id { get; set; }
        
        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; }

        [Required]
        public string Platform { get; set; }

        [Required]
        public string CommandLine { get; set; }
    }
}