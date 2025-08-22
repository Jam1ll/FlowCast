namespace FlowCast.Core.Application.ViewModels.PredictionData
{
    public class PredictionDataViewModel
    {
        public int Id { get; set; }
        public required List<decimal> Values { get; set; } = [];
    }
}
