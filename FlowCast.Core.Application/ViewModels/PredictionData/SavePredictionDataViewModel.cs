using System.ComponentModel.DataAnnotations;

namespace FlowCast.Core.Application.ViewModels.PredictionData
{
    public class SavePredictionDataViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please add more values.")]
        public required List<decimal> Values { get; set; } = [];
    }
}
