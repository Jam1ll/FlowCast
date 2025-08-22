using FlowCast.Core.Application.ViewModels.PredictionData;
using FlowCast.Core.Domain.Common.Enums;

namespace FlowCast.Core.Application.ViewModels.PredictionResults
{
    public class PredictionResultsViewModel
    {
        public int Id { get; set; }
        public decimal Results { get; set; }
        public PredictionMode PredictionMode { get; set; }
        public DateTime DateAdded { get; set; }
        public int PredictionDataId { get; set; }
        public PredictionDataViewModel? PredictionData { get; set; }
    }
}
