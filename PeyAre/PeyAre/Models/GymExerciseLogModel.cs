namespace PeyAre.Models
{
    public class GymExerciseLogModel
    {
        public int Id { get; set; } // Primary key for the log
        public string ExerciseName { get; set; } // Name of the exercise (e.g., Squats, Bench Press, etc.)
        public int Sets { get; set; } // Number of sets performed
        public int Reps { get; set; } // Number of repetitions per set
        public double Weight { get; set; } // Weight lifted (in kg or lbs)
        public DateTime Date { get; set; } // Date when the exercise was performed
        public string Notes { get; set; } // Optional field for any additional notes (e.g., "Felt strong" or "Need more rest")
    }


}

