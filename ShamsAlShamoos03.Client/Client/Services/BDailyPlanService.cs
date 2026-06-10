using Microsoft.JSInterop;
using ShamsAlShamoos03.Shared.Models;
using System.Net.Http.Json;
namespace ShamsAlShamoos03.Client.Services
{
    public class BDailyPlanService
    {
        private readonly HttpClient _http;
        private readonly IJSRuntime _js;

        public BDailyPlanService(HttpClient http, IJSRuntime js)
        {
            _http = http;
            _js = js;

        }

        public async Task<List<DailyPlanEvidence01ViewModel_Update>> LoadDataAsync(string userId)
        {
            var request = new LoadDataRequest
            {
                UserId = "123", // یا هر مقداری که می‌خواهید
                Skip = 0,
                Take = 50,
                Filter = "",
                Sort = ""
            };


            var response = await _http.PostAsJsonAsync("api/HistoryRegisterKala01/LoadData", request);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<DailyPlanEvidence01ViewModel_Update>>() ?? new();
            }
            return new();
        }
    }
}
