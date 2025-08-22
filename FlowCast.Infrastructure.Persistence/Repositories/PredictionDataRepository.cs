using FlowCast.Core.Domain.Entities;
using FlowCast.Core.Domain.Interfaces;
using FlowCast.Infrastructure.Persistence.Contexts;

namespace FlowCast.Infrastructure.Persistence.Repositories
{
    public class PredictionDataRepository : GenericRepository<PredictionData>, IPredictionDataRepository
    {
        public PredictionDataRepository(FlowCastContext context) : base(context)
        {
        }
    }
}
