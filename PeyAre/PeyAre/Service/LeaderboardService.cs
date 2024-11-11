using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using PeyAre.Models;

namespace PeyAre.Services
{
    public class LeaderboardService
    {
        private readonly HttpClient _httpClient;

        public LeaderboardService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<LeaderboardResponse> GetLeaderboardAsync(string apiKey)
        {
            var url = $"https://europe.api.riotgames.com/lor/ranked/v1/leaderboards?api_key={apiKey}";
            var response = await _httpClient.GetFromJsonAsync<LeaderboardResponse>(url);
            return response;
        }
    }

}