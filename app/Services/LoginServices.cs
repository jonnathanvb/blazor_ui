using app.Services.Dto;
using System.Net.Http.Json;

namespace app.Services
{
    public class LoginServices
    {
        private readonly HttpClient _httpClient;

        public LoginServices(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }


        public async Task<TokenDto?> Autenticar(LoginCommand command)
        {
            var result = await _httpClient.PostAsJsonAsync(_httpClient.BaseAddress + "/v1/Token", command);

            if (result != null && result.StatusCode == System.Net.HttpStatusCode.OK) {
                var dto = await result.Content.ReadFromJsonAsync<TokenDto>();
                _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", dto.Token);
                return dto;
            }

            return null;
        }
    }
}
