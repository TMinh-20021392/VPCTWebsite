using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.TaskModel;

namespace VPCT.Core.Config.MainModels.TaskModel
{
    public class ModificationConfig : IEntityTypeConfiguration<LanDieuChinh>
    {
        public void Configure(EntityTypeBuilder<LanDieuChinh> builder)
        {
            builder.ToTable(nameof(LanDieuChinh));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Date).IsRequired();
            builder.HasOne(x => x.NhiemVu).WithMany(x => x.LanDieuChinh).HasForeignKey(x => x.NhiemVuId);
        }
    }
}
