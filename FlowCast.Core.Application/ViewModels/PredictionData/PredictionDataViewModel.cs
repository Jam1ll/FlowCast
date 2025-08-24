using FlowCast.Core.Domain.Common.Enums;

namespace FlowCast.Core.Application.ViewModels.PredictionData
{
    public class PredictionDataViewModel
    {
        public int Id { get; set; }
        public required PredictionMode PredictionMode { get; set; }
        public required List<decimal> Values { get; set; } = [];
    }
}
