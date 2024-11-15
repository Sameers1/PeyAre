public class CountryPrediction
{
    public string CountryId { get; set; }
    public double Probability { get; set; }
}

public class PredictionResponse
{
    public int Count { get; set; }
    public string Name { get; set; }
    public List<CountryPrediction> Country { get; set; }
}