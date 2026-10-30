using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessApp.Models
{
    public class Athletes
    {
        [Key]
        public int athleteid { get; set; }
        public int coachid { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }

    }
}
