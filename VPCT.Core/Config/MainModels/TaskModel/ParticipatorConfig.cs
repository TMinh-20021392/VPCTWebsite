using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.TaskModel;

namespace VPCT.Core.Config.MainModels.TaskModel
{
    public class ParticipatorConfig : IEntityTypeConfiguration<CaNhanThamGia>
    {
        public void Configure(EntityTypeBuilder<CaNhanThamGia> builder)
        {
            builder.ToTable(nameof(CaNhanThamGia));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired();
            builder.HasOne(x => x.HocHam).WithMany(x => x.CaNhanThamGia).HasForeignKey(x => x.HocHamId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.HocVi).WithMany(x => x.CaNhanThamGia).HasForeignKey(x => x.HocViId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.NhiemVu).WithMany(x => x.CaNhanThamGia).HasForeignKey(x => x.NhiemVuId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
