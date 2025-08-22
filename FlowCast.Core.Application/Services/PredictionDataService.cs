using AutoMapper;
using FlowCast.Core.Application.DTOs.PredictionData;
using FlowCast.Core.Application.Interfaces;
using FlowCast.Core.Domain.Entities;
using FlowCast.Core.Domain.Interfaces;

namespace FlowCast.Core.Application.Services
{
    public class PredictionDataService(IGenericRepository<PredictionData> repository, IMapper mapper) : GenericService<PredictionData, PredictionDataDTO>(repository, mapper), IPredictionDataService
    {
    }
}
