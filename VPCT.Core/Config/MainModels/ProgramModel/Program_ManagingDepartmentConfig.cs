using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.ProgramModel;

namespace VPCT.Core.Config.MainModels.ProgramModel
{
    public class Program_ManagingDepartmentConfig : IEntityTypeConfiguration<ChuongTrinh_CoQuanQuanLy>
    {
        public void Configure(EntityTypeBuilder<ChuongTrinh_CoQuanQuanLy> builder)
        {
            builder.ToTable(nameof(ChuongTrinh_CoQuanQuanLy));
            builder.HasKey(x => new { x.ChuongTrinhId, x.CoQuanQuanLyId });
            builder.HasOne(x => x.ChuongTrinh).WithMany(x => x.ChuongTrinh_CoQuanQuanLys).HasForeignKey(x => x.ChuongTrinhId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.CoQuanQuanLy).WithMany(x => x.ChuongTrinh_CoQuanQuanLys).HasForeignKey(x => x.CoQuanQuanLyId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
