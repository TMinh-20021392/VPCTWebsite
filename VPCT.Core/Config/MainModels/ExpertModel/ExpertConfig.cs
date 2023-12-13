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
            builder.HasOne(x => x.ChucDanh).WithMany(x => x.ChuyenGia).HasForeignKey(x => x.ChucDanhId);
            builder.HasOne(x => x.HocHam).WithMany(x => x.ChuyenGia).HasForeignKey(x => x.HocHamId);
            builder.HasOne(x => x.ChucVu).WithMany(x => x.ChuyenGia).HasForeignKey(x => x.ChucVuId);
            builder.HasOne(x => x.HocVi).WithMany(x => x.ChuyenGia).HasForeignKey(x => x.HocViId);
            builder.HasOne(x => x.DonViChuQuan).WithMany(x => x.ChuyenGia).HasForeignKey(x => x.DonViChuQuanId);
            builder.HasOne(x => x.ChuyenNganh).WithMany(x => x.ChuyenGia).HasForeignKey(x => x.ChuyenNganhId);
            builder.HasOne(x => x.LinhVuc).WithMany(x => x.ChuyenGia).HasForeignKey(x => x.LinhVucId);
            builder.HasOne(x => x.CoQuanChuTri).WithMany(x => x.ChuyenGia).HasForeignKey(x => x.CoQuanChuTriId);
            builder.HasOne(x => x.ChuongTrinh).WithMany(x => x.ChuyenGia).HasForeignKey(x => x.ChuongTrinhId);
        }
    }
}
