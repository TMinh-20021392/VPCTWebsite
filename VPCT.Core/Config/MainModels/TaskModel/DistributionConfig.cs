using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.TaskModel;

namespace VPCT.Core.Config.MainModels.TaskModel
{
    public class DistributionConfig : IEntityTypeConfiguration<PhanBoNoiDung>
    {
        public void Configure(EntityTypeBuilder<PhanBoNoiDung> builder)
        {
            builder.ToTable(nameof(PhanBoNoiDung));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.NoiDung).IsRequired();
            builder.HasOne(x => x.NhiemVu).WithMany(x => x.PhanBoNoiDung).HasForeignKey(x => x.NhiemVuId);
        }
    }
}
