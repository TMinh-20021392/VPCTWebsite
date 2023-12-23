using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.TaskModel;

namespace VPCT.Core.Config.MainModels.TaskModel
{
    public class TestConfig : IEntityTypeConfiguration<LanKiemTra>
    {
        public void Configure(EntityTypeBuilder<LanKiemTra> builder)
        {
            builder.ToTable(nameof(LanKiemTra));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.EstimatedTestDate).IsRequired();
            builder.HasOne(x => x.NhiemVu).WithMany(x => x.LanKiemTra).HasForeignKey(x => x.NhiemVuId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
