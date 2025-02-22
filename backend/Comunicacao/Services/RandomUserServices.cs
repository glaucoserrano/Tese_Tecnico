using System.Text.Json;
using Comunicacao.DTO;

namespace Comunicacao.Services
{
    public class RandomUserServices 
    {
        private readonly HttpClient _httpClient;
        private const string  BASEURL = "https://randomuser.me/api/";

        public RandomUserServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<UserDTO?> GetRandomUser()
        {
            var response = await _httpClient.GetAsync(BASEURL);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Erro ao buscar usuário");
            }

            var json = await response.Content.ReadAsStringAsync();

            var userResponse = JsonSerializer.Deserialize<APIResponse>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return userResponse?.results?.FirstOrDefault();
        }
    }
}
