using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VPCT.Core.Models.DocAndFileTypes;

namespace VPCT.Core.Config.DocAndFileTypes
{
    public class DocTypeConfig : IEntityTypeConfiguration<DocType>
    {
        public void Configure(EntityTypeBuilder<DocType> builder)
        {
            builder.ToTable(nameof(DocType));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired();
        }
    }
}
