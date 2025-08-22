namespace FlowCast.Core.Domain.Entities
{
    public class PredictionData
    {
        public int Id { get; set; }
        public required List<decimal> Values { get; set; } = new List<decimal>();

        // navigation properties

        public ICollection<PredictionResults> PredictionResults { get; set; } = new List<PredictionResults>();
    }
}
