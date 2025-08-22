namespace FlowCast.Core.Application.DTOs.PredictionData
{
    public class PredictionDataDTO
    {
        public int Id { get; set; }
        public required List<decimal> Values { get; set; } = [];
    }
}
