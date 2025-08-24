using FlowCast.Core.Domain.Common.Enums;

namespace FlowCast.Core.Application.DTOs.PredictionData
{
    public class PredictionDataDTO
    {
        public int Id { get; set; }
        public required PredictionMode PredictionMode { get; set; }
        public required List<decimal> Values { get; set; } = [];
    }
}
