using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.Azure.CognitiveServices.Language.LUIS.Runtime.Models;
using PeyAre.Models;
namespace PeyAre.Service
{
    public class PredictNationService
    {
        private readonly HttpClient _httpClient;
    
        public PredictNationService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<PredictionResponse> GetPredictionResponseAsync(string apiKey)
        {
            var url = $"https://api.nationalize.io?name=johnson&apikey={apiKey}";
            var response = await _httpClient.GetFromJsonAsync<PredictionResponse>(url);
            return response;
        }



    }
}
