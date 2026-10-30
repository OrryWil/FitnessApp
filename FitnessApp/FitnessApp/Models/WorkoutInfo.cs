using System.ComponentModel.DataAnnotations;

namespace FitnessApp.Models
{
    public class WorkoutInfo
    {
        [Key]
        public int WorkoutId { get; set; }
        public int CoachId { get; set; }
        public string WorkoutName { get; set; }
        public List<Athletes> Athletes { get; set; }
        public List<Athletes> AthletesNotCompleted { get; set; }
        public DateTime WorkoutDate { get; set; }


    }
}
