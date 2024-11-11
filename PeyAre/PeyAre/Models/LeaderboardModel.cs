public class Player
{
    public string Name { get; set; }
    public int Rank { get; set; }
    public double Lp { get; set; } // League points
}

public class LeaderboardResponse
{
    public List<Player> Players { get; set; }
}