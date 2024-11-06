using System.ComponentModel.DataAnnotations;

namespace PeyAre.Data
{
    public class HistoryRPM
    {
        [Key]
        public int HistoryRPMId { get; set; }

        public int lift { get; set; }
        public int reps { get; set; }

        public string SelectedLift { get; set; }

        public List<string> AvailableLifts { get; set; } = new List<string>
        {
            "Bench Press",
            "Squat",
            "Deadlift",
            "Overhead Press"
        };

    }
}
