using System.ComponentModel.DataAnnotations;

namespace FitnessApp.Models
{
    public class User
    {
        [Key]
        public int CoachId { get; set; }
        public string Name { get; set; }
        public Boolean isCoach { get; set; }

        public string email {  get; set; }
        public string passwordhash { get; set; }
    }
}
