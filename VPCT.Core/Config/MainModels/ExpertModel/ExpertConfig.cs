using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.ExpertModel;

namespace VPCT.Core.Config.MainModels.ExpertModel
{
    public class ExpertConfig : IEntityTypeConfiguration<ChuyenGia>
    {
        public void Configure(EntityTypeBuilder<ChuyenGia> builder)
        {
            builder.ToTable(nameof(ChuyenGia));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired();
            builder.HasOne(x => x.ChucDanh).WithMany(x => x.ChuyenGia).HasForeignKey(x => x.ChucDanhId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.HocHam).WithMany(x => x.ChuyenGia).HasForeignKey(x => x.HocHamId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.ChucVu).WithMany(x => x.ChuyenGia).HasForeignKey(x => x.ChucVuId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.HocVi).WithMany(x => x.ChuyenGia).HasForeignKey(x => x.HocViId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.DonViChuQuan).WithMany(x => x.ChuyenGia).HasForeignKey(x => x.DonViChuQuanId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.ChuyenNganh).WithMany(x => x.ChuyenGia).HasForeignKey(x => x.ChuyenNganhId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.LinhVuc).WithMany(x => x.ChuyenGia).HasForeignKey(x => x.LinhVucId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.CoQuanChuTri).WithMany(x => x.ChuyenGia).HasForeignKey(x => x.CoQuanChuTriId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.ChuongTrinh).WithMany(x => x.ChuyenGia).HasForeignKey(x => x.ChuongTrinhId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
