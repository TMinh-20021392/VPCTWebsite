using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.TaskModel;
using VPCT.Core.Models.MainModels.TaskModel.Enums;

namespace VPCT.Core.Config.MainModels.TaskModel
{
    public class ScienceCouncilConfig : IEntityTypeConfiguration<HoiDongKhoaHoc>
    {
        public void Configure(EntityTypeBuilder<HoiDongKhoaHoc> builder)
        {
            builder.ToTable(nameof(HoiDongKhoaHoc));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Category).IsRequired()
                .HasConversion(
                    v => v.ToString(),
                    v => (LoaiHoiDong)Enum.Parse(typeof(LoaiHoiDong), v));
            builder.HasOne(x => x.NhiemVu).WithMany(x => x.HoiDongKhoaHoc).HasForeignKey(x => x.NhiemVuId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
