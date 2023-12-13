using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VPCT.Core.Models.MainModels.DepartmentModel;
using static VPCT.Core.Models.MainModels.DepartmentModel.CoQuanQuanLy;

namespace VPCT.Core.Config.MainModels.DepartmentModel
{
    public class ManagingDepartmentConfig : IEntityTypeConfiguration<CoQuanQuanLy>
    {
        public void Configure(EntityTypeBuilder<CoQuanQuanLy> builder)
        {
            builder.ToTable(nameof(CoQuanQuanLy));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Type).IsRequired()
                .HasConversion(
                    v => v.ToString(),
                    v => (LoaiQuanLy)Enum.Parse(typeof(LoaiQuanLy), v));
        }
    }
}
