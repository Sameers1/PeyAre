using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using PeyAre.Models;

namespace PeyAre.Services
{
    public class LeaderboardService
    {
        private readonly HttpClient _httpClient;
        private const string ApiUrl = "https://europe.api.riotgames.com/lor/ranked/v1/leaderboards";

        public LeaderboardService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<LeaderboardResponse> GetLeaderboardAsync(string apiKey)
        {
            try
            {
                var response = await _httpClient.GetFromJsonAsync<LeaderboardResponse>($"{ApiUrl}?api_key={apiKey}");
                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching leaderboard data: {ex.Message}");
                return null;
            }
        }
    }
}