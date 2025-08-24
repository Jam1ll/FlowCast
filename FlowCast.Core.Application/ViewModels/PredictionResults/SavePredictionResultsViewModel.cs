using FlowCast.Core.Application.ViewModels.PredictionData;
using FlowCast.Core.Domain.Common.Enums;
using System.ComponentModel.DataAnnotations;

namespace FlowCast.Core.Application.ViewModels.PredictionResults
{
    public class SavePredictionResultsViewModel
    {
        public int Id { get; set; }
              
        [Required(ErrorMessage = "Please add a prediction's mode")]
        public PredictionMode PredictionMode { get; set; }
        
        [Required(ErrorMessage = "Please add a description")]
        public required string Description { get; set; }
        public DateTime DateAdded { get; set; }
        
        [Required(ErrorMessage = "Please add the prediction's data")]
        public int PredictionDataId { get; set; }
        public PredictionDataViewModel? PredictionData { get; set; }
    }
}
