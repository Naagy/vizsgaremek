using Real.Backend.Context;
using Real.Backend.Repos.Base;
using Real.Shared.Models;

namespace Real.Backend.Repos
{
    public class SubjectRepo<TDbContext> : BaseRepo<TDbContext, Subject>, ISubjectRepo where TDbContext : RealContext
    {
        public SubjectRepo(TDbContext? dbContext) : base(dbContext)
        {
        }
    }
}
