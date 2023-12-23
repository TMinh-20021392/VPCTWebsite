using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.ExpertModel;

namespace VPCT.Core.Config.MainModels.ExpertModel
{
    public class ProjectConfig : IEntityTypeConfiguration<CongTrinh>
    {
        public void Configure(EntityTypeBuilder<CongTrinh> builder)
        {
            builder.ToTable(nameof(CongTrinh));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Scope_Address).IsRequired();
            builder.HasOne(x => x.ChuyenGia).WithMany(x => x.CongTrinh).HasForeignKey(x => x.ChuyenGiaId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
