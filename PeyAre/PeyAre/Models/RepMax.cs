using System.ComponentModel.DataAnnotations;

namespace PeyAre.Data
{
    public class RepMax
    {
        public int Id { get; set; }
        public string LiftName { get; set; }   // The name of the lift (e.g., "Bench Press")
        public decimal WeightLifted { get; set; }  // The weight lifted
        public int Reps { get; set; }         // The number of reps performed
        public decimal OneRepMax { get; set; }   // The calculated 1RM
        public DateTime Date { get; set; }        // Date of the lift attempt
    }

}
