using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.ProgramModel;

namespace VPCT.Core.Config.MainModels.ProgramModel
{
    public class ProgramConfig : IEntityTypeConfiguration<ChuongTrinh>
    {
        public void Configure(EntityTypeBuilder<ChuongTrinh> builder)
        {
            builder.ToTable(nameof(ChuongTrinh));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired();
            builder.HasOne(x => x.LoaiChuongTrinh).WithMany(x => x.ChuongTrinh).HasForeignKey(x => x.LoaiChuongTrinhId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.CoQuanChuTri).WithMany(x => x.ChuongTrinh).HasForeignKey(x => x.CoQuanChuTriId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
