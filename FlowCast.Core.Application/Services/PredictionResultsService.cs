using AutoMapper;
using FlowCast.Core.Application.DTOs.PredictionResults;
using FlowCast.Core.Application.Interfaces;
using FlowCast.Core.Domain.Entities;
using FlowCast.Core.Domain.Interfaces;

namespace FlowCast.Core.Application.Services
{
    public class PredictionResultsService(IGenericRepository<PredictionResults> repository, IMapper mapper) : GenericService<PredictionResults, PredictionResultsDTO>(repository, mapper), IPredictionResultsService
    {
    }
}
