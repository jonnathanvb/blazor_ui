using app.Services.Command;
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

        public async Task<IEnumerable<PedidoDto>?> GetAllPedido()
        {
            var result = await _httpClient.GetFromJsonAsync<IEnumerable<PedidoDto>>(_httpClient.BaseAddress + "/v1/Pedido");

            return result;
        }

        public async Task<ProdutoCommand> Get(int id)
        {
            return await _httpClient.GetFromJsonAsync<ProdutoCommand>(_httpClient.BaseAddress + $"/v1/Produto/{id}");
        }

        public async Task<bool> Post(ProdutoCommand command)
        {
            var result = await this._httpClient.PostAsJsonAsync(_httpClient.BaseAddress + "/v1/Produto", command);
            if (result != null && result.StatusCode == System.Net.HttpStatusCode.Created)
            {
                return true;
            }

            return false;
        }

        public async Task<bool> Put(ProdutoCommand command)
        {
            var result = await this._httpClient.PutAsJsonAsync(_httpClient.BaseAddress + $"/v1/Produto/{command.Id}", command);
            if (result != null && result.StatusCode == System.Net.HttpStatusCode.NoContent)
            {
                return true;
            }

            return false;
        }
    }
}
