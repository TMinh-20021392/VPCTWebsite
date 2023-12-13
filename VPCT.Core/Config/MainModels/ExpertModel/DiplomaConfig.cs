using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.ExpertModel;

namespace VPCT.Core.Config.MainModels.ExpertModel
{
    public class DiplomaConfig : IEntityTypeConfiguration<VanBang>
    {
        public void Configure(EntityTypeBuilder<VanBang> builder)
        {
            builder.ToTable(nameof(VanBang));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Year).IsRequired();
            builder.HasOne(x => x.ChuyenGia).WithMany(x => x.VanBang).HasForeignKey(x => x.ChuyenGiaId);
        }
    }
}
