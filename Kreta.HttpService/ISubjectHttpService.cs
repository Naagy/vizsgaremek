using Real.Shared.Models;
using Real.Shared.Responses;

namespace Real.HttpService
{
    public interface ISubjectHttpService
    {
        Task<List<Player>> GetAllAsync();
        Task<Player> GetByIdAsync(Guid id);
        Task<Response> CreateAsync(Player player);
        Task<Response> UpdateAsync(Player player);
        Task<Response> DeleteAsync(Guid id);
    }
}
