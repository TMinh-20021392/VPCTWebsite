using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.DepartmentModel;

namespace VPCT.Core.Config.MainModels.DepartmentModel
{
    public class DepartmentConfig : IEntityTypeConfiguration<DonViChuQuan>
    {
        public void Configure(EntityTypeBuilder<DonViChuQuan> builder)
        {
            builder.ToTable(nameof(DonViChuQuan));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired();
        }
    }
}
