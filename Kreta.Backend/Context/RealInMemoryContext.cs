using Microsoft.EntityFrameworkCore;

namespace Real.Backend.Context
{
    public class RealInMemoryContext : RealContext
    {
        public RealInMemoryContext(DbContextOptions<RealContext> options) : base(options)
        {
        }
    }
}
