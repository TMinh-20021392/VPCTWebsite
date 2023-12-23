using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VPCT.Core.Models.MainModels.ExpertModel;

namespace VPCT.Core.Config.MainModels.ExpertModel
{
    public class AwardConfig : IEntityTypeConfiguration<GiaiThuong>
    {
        public void Configure(EntityTypeBuilder<GiaiThuong> builder)
        {
            builder.ToTable(nameof(GiaiThuong));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired();
            builder.HasOne(x => x.ChuyenGia).WithMany(x => x.GiaiThuong).HasForeignKey(x => x.ChuyenGiaId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
