using Real.Shared.Models;
using Real.Shared.Responses;

namespace Real.HttpService.Base
{
    public interface IBaseHttpService<TModel>
    {
        Task<List<TModel>> GetAllAsync();
        Task<TModel> GetByIdAsync(Guid id);
        Task<Response> CreateAsync(TModel player);
        Task<Response> UpdateAsync(TModel player);
        Task<Response> DeleteAsync(Guid id);
    }
}
