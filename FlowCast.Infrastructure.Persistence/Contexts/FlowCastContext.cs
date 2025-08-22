using FlowCast.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace FlowCast.Infrastructure.Persistence.Contexts
{
    public class FlowCastContext : DbContext
    {
        public FlowCastContext(DbContextOptions<FlowCastContext> options) : base(options) { }

        // dbSets

        public DbSet<PredictionData> PredictionDatas { get; set; }
        public DbSet<PredictionResults> PredictionResults { get; set; }

        // entity configurations

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
