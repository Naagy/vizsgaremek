using Real.Backend.Repos.Base;
using Real.Shared.Enums;
using Real.Shared.Models;

namespace Real.Backend.Repos
{
    public interface IPlayerRepo : IBaseRepo<Player>
    {
        Task<Player> GetByNameAsync(string firstName, string lastName);
        Task<List<Player>> GetPLayerByClassAsync(int RealYear, RealClassType realClassType);
        Task<int> GetNumberOfPlayerAsync();
    }
}
