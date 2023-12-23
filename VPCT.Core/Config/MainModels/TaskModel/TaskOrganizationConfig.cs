using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.TaskModel;
using VPCT.Core.Models.MainModels.TaskModel.Enums;

namespace VPCT.Core.Config.MainModels.TaskModel
{
    public class TaskOrganizationConfig : IEntityTypeConfiguration<CoQuanChuTri_NhiemVu>
    {
        public void Configure(EntityTypeBuilder<CoQuanChuTri_NhiemVu> builder)
        {
            builder.ToTable(nameof(CoQuanChuTri_NhiemVu));
            builder.HasKey(x => new { x.NhiemVuId, x.DonViChuQuanId, x.CoQuanChuTriId });
            builder.Property(x => x.Filer)
                .HasConversion(
                    v => v.HasValue ? v.Value.ToString() : null,
                    v => v != null ? (LoaiHoSo)Enum.Parse(typeof(LoaiHoSo), v) : null);
            builder.HasOne(x => x.NhiemVu).WithMany(x => x.CoQuanChuTri_NhiemVu).HasForeignKey(x => x.NhiemVuId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.DonViChuQuan).WithMany(x => x.CoQuanChuTri_NhiemVu).HasForeignKey(x => x.DonViChuQuanId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.CoQuanChuTri).WithMany(x => x.CoQuanChuTri_NhiemVu).HasForeignKey(x => x.CoQuanChuTriId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
