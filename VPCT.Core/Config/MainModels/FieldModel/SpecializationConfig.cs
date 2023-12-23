using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.FieldModel;

namespace VPCT.Core.Config.MainModels.FieldModel
{
    public class SpecializationConfig : IEntityTypeConfiguration<ChuyenNganh>
    {
        public void Configure(EntityTypeBuilder<ChuyenNganh> builder)
        {
            builder.ToTable(nameof(ChuyenNganh));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired();
            builder.HasOne(x => x.LinhVuc).WithMany(x => x.ChuyenNganhs).HasForeignKey(x => x.LinhVucId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
