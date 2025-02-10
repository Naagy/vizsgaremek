using Real.HttpService.Base;
using Real.Shared.Models;

namespace Real.HttpService
{
    public interface IPlayerHttpService : IBaseHttpService<Player>
    {
        Task<int> GetNumberOfPlayerAsync();
    }
}
