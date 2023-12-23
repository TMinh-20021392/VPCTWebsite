using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VPCT.Core.Models.MainModels.TaskModel;
using VPCT.Core.Models.MainModels.TaskModel.Enums;

namespace VPCT.Core.Config.MainModels.TaskModel
{
    public class TaskConfig : IEntityTypeConfiguration<NhiemVu>
    {
        public void Configure(EntityTypeBuilder<NhiemVu> builder)
        {
            builder.ToTable(nameof(NhiemVu));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.MaNhiemVu).IsRequired();
            builder.Property(x => x.Category).IsRequired()
                .HasConversion(
                    v => v.ToString(),
                    v => (LoaiNhiemVu)Enum.Parse(typeof(LoaiNhiemVu), v));
            builder.Property(x => x.Status).IsRequired()
                .HasConversion(
                    v => v.ToString(),
                    v => (TrangThaiNhiemVu)Enum.Parse(typeof(TrangThaiNhiemVu), v));
            builder.Property(x => x.KetQua)
                .HasConversion(
                    v => v.HasValue ? v.Value.ToString() : null,
                    v => v != null ? (KetQua)Enum.Parse(typeof(KetQua), v) : null);
            builder.HasOne(x => x.ChuongTrinh).WithMany(x => x.NhiemVu).HasForeignKey(x => x.ChuongTrinhId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.President).WithMany(x => x.NhiemVu).HasForeignKey(x => x.PresidentId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.CoQuanChuTri).WithMany(x => x.NhiemVu).HasForeignKey(x => x.CoQuanChuTriId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.LinhVuc).WithMany(x => x.NhiemVu).HasForeignKey(x => x.LinhVucId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.ChuyenNganh).WithMany(x => x.NhiemVu).HasForeignKey(x => x.ChuyenNganhId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.CoQuanQuanLyKinhPhi).WithMany(x => x.CostManagingTasks).HasForeignKey(x => x.CoQuanQuanLyKinhPhiId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.CoQuanQuanLyNhiemVu).WithMany(x => x.TaskManagingTasks).HasForeignKey(x => x.CoQuanQuanLyNhiemVuId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
