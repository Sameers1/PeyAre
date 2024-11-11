public class LeaderboardModel
{
    public string Name { get; set; }
    public int Rank { get; set; }
    public double Lp { get; set; } // League points
}

public class LeaderboardResponse
{
    public List<LeaderboardModel> Leaderboard { get; set; }
}