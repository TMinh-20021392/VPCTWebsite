using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.ExpertModel;

namespace VPCT.Core.Config.MainModels.ExpertModel
{
    public class TitleConfig : IEntityTypeConfiguration<ChucDanh>
    {
        public void Configure(EntityTypeBuilder<ChucDanh> builder)
        {
            builder.ToTable(nameof(ChucDanh));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired();
        }
    }
}
