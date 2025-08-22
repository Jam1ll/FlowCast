namespace FlowCast.Core.Domain.Entities
{
    public class PredictionResults
    {
        public int Id { get; set; }
        public decimal Results {  get; set; }
        public DateTime DateAdded { get; set; }
      
        // navigation property
     
        public int PredictionDataId { get; set; }
        public PredictionData? PredictionData { get; set; }
    }
}
