using FlowCast.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlowCast.Infrastructure.Persistence.EntityConfigurations
{
    public class PredictionDataEntityConfiguration : IEntityTypeConfiguration<PredictionData>
    {
        public void Configure(EntityTypeBuilder<PredictionData> builder)
        {
            builder.ToTable("PredictionDatas");
            builder.HasKey(pd => pd.Id);

            builder.Property(pd => pd.Values).IsRequired();

            #region relationships

            builder
                .HasMany(pd => pd.PredictionResults)
                .WithOne(pr => pr.PredictionData)
                .HasForeignKey(pr => pr.PredictionDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            #endregion
        }
    }
}
