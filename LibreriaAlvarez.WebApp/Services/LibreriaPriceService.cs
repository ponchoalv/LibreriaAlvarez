using Microsoft.AspNetCore.Blazor;
using System.Net.Http;
using System.Threading.Tasks;

namespace LibreriaAlvarez.WebApp.Services
{
    public class LibreriaPriceService
    {
        private readonly HttpClient _httpClient;
        private readonly string APIBaseURL;

        public LibreriaPriceService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            APIBaseURL = "http://localhost:3000/api/";
        }
        public async Task<LibreriaPrice[]> GetPricesAsync()
        {
            var lastDate = await _httpClient.GetJsonAsync<string>(APIBaseURL + "get-last-date").ConfigureAwait(false);
            return await _httpClient.GetJsonAsync<LibreriaPrice[]>(APIBaseURL + "prices-by-fecha?fecha=" + lastDate).ConfigureAwait(false);
        }
        public async Task<HttpResponseMessage> PostCargarPlanilla(MultipartFormDataContent form) => await _httpClient.PostAsync(APIBaseURL + "cargar-lista", form);
    }
}
