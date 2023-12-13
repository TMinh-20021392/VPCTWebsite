using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.TaskModel;
using VPCT.Core.Models.MainModels.TaskModel.Enums;

namespace VPCT.Core.Config
{
    public class ExpertCouncilRoleConfig : IEntityTypeConfiguration<HoiDongKhoaHoc_ChuyenGia>
    {
        public void Configure(EntityTypeBuilder<HoiDongKhoaHoc_ChuyenGia> builder)
        {
            builder.ToTable(nameof(HoiDongKhoaHoc_ChuyenGia));
            builder.HasKey(x => new { x.HoiDongKhoaHocId, x.ChuyenGiaId });
            builder.Property(x => x.ChucDanh).IsRequired()
                .HasConversion(
                    v => v.ToString(),
                    v => (ChucDanhHoiDong)Enum.Parse(typeof(ChucDanhHoiDong), v));
            builder.HasOne(x => x.ChuyenGia).WithMany(x => x.HoiDongKhoaHoc_ChuyenGia).HasForeignKey(x => x.ChuyenGiaId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.HoiDongKhoaHoc).WithMany(x => x.HoiDongKhoaHoc_ChuyenGia).HasForeignKey(x => x.HoiDongKhoaHocId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
