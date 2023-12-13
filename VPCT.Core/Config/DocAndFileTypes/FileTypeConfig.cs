using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.DocAndFileTypes;

namespace VPCT.Core.Config.DocAndFileTypes
{
    public class FileTypeConfig : IEntityTypeConfiguration<FileType>
    {
        public void Configure(EntityTypeBuilder<FileType> builder)
        {
            builder.ToTable(nameof(FileType));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired();
        }
    }
}
