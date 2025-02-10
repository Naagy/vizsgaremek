using Real.HttpService.Base;
using Real.Shared.Assemblers;
using Real.Shared.Dtos;
using Real.Shared.Models;
using System.Net.Http.Json;

namespace Real.HttpService
{
    public class PlayerHttpService : BaseHttpService<Player, PlayerDto>, IPlayerHttpService
    {
        public PlayerHttpService(IHttpClientFactory? httpClientFactory, PlayerAssembler assambler) : base(httpClientFactory, assambler)
        {
        }

        public PlayerHttpService() : base()
        {            
        }

        public async Task<int> GetNumberOfPlayerAsync()
        {
            try
            {
                int numberOfPlayer = await _httpClient.GetFromJsonAsync<int>("api/Player/NumberOfPlayer");
                return numberOfPlayer;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return -1;
        }
    }
}
