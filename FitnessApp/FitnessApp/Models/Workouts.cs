using System.ComponentModel.DataAnnotations;

namespace FitnessApp.Models
{
    public class Workouts
    {
        [Key]
        public int workoutid { get; set; }
        public int workoutinfoid { get; set; }
        public int exerciseid { get; set; }
        public int workoutsets { get; set; }
        public int workoutreps { get; set; }
        public List<WorkoutResults> workoutresults { get; set; }

    }
}
