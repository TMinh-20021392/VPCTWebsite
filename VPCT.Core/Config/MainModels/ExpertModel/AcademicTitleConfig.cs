using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.ExpertModel;

namespace VPCT.Core.Config.MainModels.ExpertModel
{
    public class AcademicTitleConfig : IEntityTypeConfiguration<HocHam>
    {
        public void Configure(EntityTypeBuilder<HocHam> builder)
        {
            builder.ToTable(nameof(HocHam));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired();
        }
    }
}
