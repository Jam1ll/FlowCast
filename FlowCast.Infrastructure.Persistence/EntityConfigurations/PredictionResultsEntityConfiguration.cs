using FlowCast.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlowCast.Infrastructure.Persistence.EntityConfigurations
{
    public class PredictionResultsEntityConfiguration : IEntityTypeConfiguration<PredictionResults>
    {
        public void Configure(EntityTypeBuilder<PredictionResults> builder)
        {
            builder.ToTable("PredictionResults");
            builder.HasKey(pr => pr.Id);

            builder.Property(pr => pr.PredictionMode).IsRequired();
            builder.Property(pr => pr.DateAdded).IsRequired();

            #region relationships

            builder
                .HasOne(pr => pr.PredictionData)
                .WithMany(pd => pd.PredictionResults)
                .HasForeignKey(pr => pr.PredictionDataId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            #endregion
        }
    }
}
