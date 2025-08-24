using FlowCast.Core.Application.DTOs.PredictionData;
using FlowCast.Core.Application.DTOs.PredictionResults;
using Microsoft.AspNetCore.Mvc;

namespace FlowCast.Core.Application.Interfaces
{
    public interface IPredictionResultsService : IGenericService<PredictionResultsDTO>
    {
        Task<PredictionResultsDTO> CalculateResults(PredictionDataDTO dto);
    }
}
