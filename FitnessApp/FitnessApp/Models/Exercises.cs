using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessApp.Models
{
    [Table("exercises")]
    public class Exercises
    {
        [Key]
        public int exerciseid { get; set; }
        public string exercisename { get; set; }
        public string ?videourl { get; set; }
        public string ?description { get; set; }

    }
}
