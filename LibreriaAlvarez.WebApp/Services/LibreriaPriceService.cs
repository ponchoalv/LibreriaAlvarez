using Microsoft.AspNetCore.Blazor;
using System.Net.Http;
using System.Threading.Tasks;

namespace LibreriaAlvarez.WebApp.Services
{
    public class LibreriaPriceService
    {
        private readonly HttpClient _httpClient;

        public LibreriaPriceService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<LibreriaPrice[]> GetPricesAsync()
        {
            var lastDate = await _httpClient.GetJsonAsync<string>("http://localhost:3000/api/get-last-date").ConfigureAwait(false);
            return await _httpClient.GetJsonAsync<LibreriaPrice[]>("http://localhost:3000/api/prices-by-fecha?fecha=" + lastDate).ConfigureAwait(false);
        }
    }
}
