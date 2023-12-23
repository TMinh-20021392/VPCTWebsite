using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VPCT.Core.Models.MainModels.DepartmentModel;

namespace VPCT.Core.Config.MainModels.DepartmentModel
{
    public class OrganizationConfig : IEntityTypeConfiguration<CoQuanChuTri>
    {
        public void Configure(EntityTypeBuilder<CoQuanChuTri> builder)
        {
            builder.ToTable(nameof(CoQuanChuTri));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired();
            builder.HasOne(x => x.DonViChuQuan).WithMany(x => x.CoQuanChuTri).HasForeignKey(x => x.DonViChuQuanId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
