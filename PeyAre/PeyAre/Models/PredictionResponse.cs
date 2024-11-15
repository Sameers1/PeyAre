namespace PeyAre.Models
{
    public class NameData
    {
        public int Count { get; set; }
        public string Name { get; set; }
        public List<CountryProbability> Country { get; set; }
    }
    public class CountryProbability
    {
        public string CountryId { get; set; }
        public double Probability { get; set; }
    }

   
}