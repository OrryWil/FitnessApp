using System.ComponentModel.DataAnnotations;

namespace FitnessApp.Models
{
    public class WorkoutInfo
    {
        [Key]
        public int workoutinfoid { get; set; }
        public int coachid { get; set; }
        public string workoutname { get; set; }
        public DateTime workoutdate { get; set; }


    }
}
