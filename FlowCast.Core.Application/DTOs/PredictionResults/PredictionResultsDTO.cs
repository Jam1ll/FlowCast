using FlowCast.Core.Application.DTOs.PredictionData;
using FlowCast.Core.Domain.Common.Enums;

namespace FlowCast.Core.Application.DTOs.PredictionResults
{
    public class PredictionResultsDTO
    {
        public int Id { get; set; }
        public PredictionMode PredictionMode { get; set; }
        public required string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public int PredictionDataId { get; set; }
        public PredictionDataDTO? PredictionData { get; set; }
    }
}
