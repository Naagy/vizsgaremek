using Real.Shared.Models;
using Real.Shared.Responses;
using System.Linq.Expressions;

namespace Real.Backend.Repos.Base
{
    public interface IBaseRepo <TEntity> where TEntity : class , IDbEntity<TEntity>, new()
    {
        public Task<IEnumerable<TEntity>> GetAllAsync();
        public Task<IEnumerable<TEntity>> FindByConditionAsync(Expression<Func<TEntity, bool>> expression);
        public Task<Response> UpdateAsync(TEntity entity);
        public Task<Response> CreateAsync(TEntity entity);
        public Task<Response> DeleteAsync(Guid id);
    }
}
