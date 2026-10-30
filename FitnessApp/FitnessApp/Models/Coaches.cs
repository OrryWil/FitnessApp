using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessApp.Models
{
    [Table("coaches")]
    public class Coaches
    {
        [Key]
        public int coachid { get; set; } = -1;
        public string lastname { get; set; }
        public string passwordhash { get; set; }
        public string email { get; set; }
        public string phonenumber { get; set; }
        public string? company { get; set; }
        public List<Athletes> Athletes { get; set; }
    }
}
