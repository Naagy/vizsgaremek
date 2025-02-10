using Real.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Real.Backend.Context
{
    public class RealContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        public RealContext(DbContextOptions<RealContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }
    }
}
