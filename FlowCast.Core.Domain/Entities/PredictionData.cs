namespace FlowCast.Core.Domain.Entities
{
    public class PredictionData
    {
        public int Id { get; set; }
        public required List<decimal> Values { get; set; } = new List<decimal>();
    }
}
