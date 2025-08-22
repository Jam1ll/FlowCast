using FlowCast.Core.Domain.Entities;
using FlowCast.Core.Domain.Interfaces;
using FlowCast.Infrastructure.Persistence.Contexts;

namespace FlowCast.Infrastructure.Persistence.Repositories
{
    public class PredictionResultsRepository(FlowCastContext context) : GenericRepository<PredictionResults>(context), IPredictionResultsRepository
    {
    }
}
