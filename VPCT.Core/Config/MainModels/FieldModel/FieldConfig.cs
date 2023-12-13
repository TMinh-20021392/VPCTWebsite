using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.FieldModel;

namespace VPCT.Core.Config.MainModels.FieldModel
{
    public class FieldConfig : IEntityTypeConfiguration<LinhVuc>
    {
        public void Configure(EntityTypeBuilder<LinhVuc> builder)
        {
            builder.ToTable(nameof(LinhVuc));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired();
        }
    }
}
