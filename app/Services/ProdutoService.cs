using app.Services.Dto;
using System.Net.Http.Json;

namespace app.Services
{
    public class ProdutoServices
    {
        private readonly HttpClient _httpClient;

        public ProdutoServices(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }


        public async Task<IEnumerable<ProdutoDto>?> GetAll()
        {
            var result = await _httpClient.GetFromJsonAsync<IEnumerable<ProdutoDto>>(_httpClient.BaseAddress + "/v1/Produto");

            return result;
        }
    }
}
