using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models;

namespace VPCT.Core.Config.MainModels
{
    public class PeriodConfig : IEntityTypeConfiguration<GiaiDoan>
    {
        public void Configure(EntityTypeBuilder<GiaiDoan> builder)
        {
            builder.ToTable(nameof(GiaiDoan));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Start).IsRequired();
            builder.Property(x => x.End).IsRequired();
        }
    }
}
