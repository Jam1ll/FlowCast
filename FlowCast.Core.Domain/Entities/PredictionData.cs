using FlowCast.Core.Domain.Common.Enums;

namespace FlowCast.Core.Domain.Entities
{
    public class PredictionData
    {
        public int Id { get; set; }
        public required PredictionMode PredictionMode { get; set; }
        public required List<decimal> Values { get; set; } = [];

        // navigation properties

        public ICollection<PredictionResults> PredictionResults { get; set; } = [];
    }
}
