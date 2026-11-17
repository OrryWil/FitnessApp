using System.ComponentModel.DataAnnotations;

namespace FitnessApp.Models
{
    public class WorkoutResults
    {
        [Key]
        public int resultid { get; set; }
        public int workoutid { get; set; }
        public int assignmentid { get; set; }
        public int askedweight { get; set; }
        public int actualweightdone { get; set; }
        public bool completed { get; set; }
    }
}
