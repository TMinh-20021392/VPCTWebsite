using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.ExpertModel;

namespace VPCT.Core.Config.MainModels.ExpertModel
{
    public class PublicationConfig : IEntityTypeConfiguration<AnPham>
    {
        public void Configure(EntityTypeBuilder<AnPham> builder)
        {
            builder.ToTable(nameof(AnPham));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.TapChi).IsRequired();
            builder.HasOne(x => x.ChuyenGia).WithMany(x => x.AnPham).HasForeignKey(x => x.ChuyenGiaId);
        }
    }
}
