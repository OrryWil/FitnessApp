using System.ComponentModel.DataAnnotations;

namespace FitnessApp.Models
{
    public class WorkoutAssignments
    {
        [Key]
        public int assignmentid { get; set; }
        public int workoutinfoid { get; set; }
        public int athleteid { get; set; }
        public Athletes athlete { get; set; }
        public List<WorkoutResults> workoutresults { get; set; }
    }
}
