using System.ComponentModel.DataAnnotations;

namespace FitnessApp.Models
{
    public class WorkoutInfo
    {
        [Key]
        public int workoutid { get; set; }
        public int coachid { get; set; }
        public string workoutname { get; set; }
        public List<Athletes> athletes { get; set; }
        public List<Athletes> athletesnotcompleted { get; set; }
        public DateTime workoutdate { get; set; }


    }
}
