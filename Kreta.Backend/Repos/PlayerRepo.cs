using Microsoft.EntityFrameworkCore;
using Real.Backend.Context;
using Real.Backend.Repos.Base;
using Real.Backend.Repos;
using Real.Shared.Enums;
using Real.Shared.Models;

public class PlayerRepo<TDbContext> : BaseRepo<TDbContext, Player>, IPlayerRepo where TDbContext : RealContext
{
    public PlayerRepo(TDbContext? dbContext) : base(dbContext)
    {
    }

    public async Task<Player> GetByNameAsync(string firstName, string lastName)
    {
        return await _dbSet!.FindByCondition<Player>(s => s.FirstName == firstName && s.LastName == lastName).FirstOrDefaultAsync() ?? new Player();
    }

    public async Task<List<Player>> GetPLayerByClassAsync(int realYear, RealClassType realClassType)
    {
        return await _dbSet!
            .FindByCondition<Player>(s => s.RealYear == realYear && s.RealClass == realClassType).ToListAsync();
    }

    public async Task<int> GetNumberOfPlayerAsync()
    {
        return await _dbSet!.CountAsync();
    }
}
