using Real.Shared.Dtos;
using Real.Shared.Extensions;
using Real.Shared.Models;
using Real.Shared.Responses;
using System.Net.Http.Json;

namespace Real.HttpService
{
    public class SubjectHttpService : ISubjectHttpService
    {
        private readonly HttpClient _httpClient;

        public SubjectHttpService()
        {
            _httpClient = new HttpClient();
        }
        public SubjectHttpService(IHttpClientFactory? httpClientFactory)
        {
            if (httpClientFactory == null) throw new ArgumentNullException(nameof(httpClientFactory));
            _httpClient = httpClientFactory.CreateClient("RealApi");
        }
        public Task<Response> CreateAsync(Player player)
        {
            throw new NotImplementedException();
        }

        public Task<Response> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Player>> GetAllAsync()
        {
            try
            {
                List<PlayerDto>? resultDto = await _httpClient.GetFromJsonAsync<List<PlayerDto>>("api/Player");
                if (resultDto != null)
                    return resultDto.Select(dto => dto.ToPlayer()).ToList();
            }
            catch (Exception ex)
            {
            }
            return new List<Player>();
        }

        public Task<Player> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Response> UpdateAsync(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
