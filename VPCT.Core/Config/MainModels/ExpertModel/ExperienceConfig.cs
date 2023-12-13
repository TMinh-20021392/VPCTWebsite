using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.ExpertModel;
using static VPCT.Core.Models.MainModels.ExpertModel.KinhNghiem;

namespace VPCT.Core.Config.MainModels.ExpertModel
{
    public class ExperienceConfig : IEntityTypeConfiguration<KinhNghiem>
    {
        public void Configure(EntityTypeBuilder<KinhNghiem> builder)
        {
            builder.ToTable(nameof(KinhNghiem));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.CoQuan).IsRequired();
            builder.Property(x => x.Type).IsRequired()
                .HasConversion(
                    v => v.ToString(),
                    v => (LoaiKinhNghiem)Enum.Parse(typeof(LoaiKinhNghiem), v));
            builder.HasOne(x => x.ChuyenGia).WithMany(x => x.KinhNghiem).HasForeignKey(x => x.ChuyenGiaId);
        }
    }
}
