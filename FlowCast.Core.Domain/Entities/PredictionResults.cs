using FlowCast.Core.Domain.Common.Enums;

namespace FlowCast.Core.Domain.Entities
{
    public class PredictionResults
    {
        public int Id { get; set; }
        public PredictionMode PredictionMode { get; set; }
        public required string Description { get; set; }
        public DateTime DateAdded { get; set; }
      
        // navigation property
     
        public int PredictionDataId { get; set; }
        public PredictionData? PredictionData { get; set; }
    }
}
