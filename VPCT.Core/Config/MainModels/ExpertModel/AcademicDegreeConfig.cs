using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.ExpertModel;

namespace VPCT.Core.Config.MainModels.ExpertModel
{
    public class AcademicDegreeConfig : IEntityTypeConfiguration<HocVi>
    {
        public void Configure(EntityTypeBuilder<HocVi> builder)
        {
            builder.ToTable(nameof(HocVi));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired();
        }
    }
}
