using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.ExpertModel;

namespace VPCT.Core.Config.MainModels.ExpertModel
{
    public class OtherActivityConfig : IEntityTypeConfiguration<HoatDongKhac>
    {
        public void Configure(EntityTypeBuilder<HoatDongKhac> builder)
        {
            builder.ToTable(nameof(HoatDongKhac));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired();
            builder.HasOne(x => x.ChuyenGia).WithMany(x => x.HoatDongKhac).HasForeignKey(x => x.ChuyenGiaId);
        }
    }
}
