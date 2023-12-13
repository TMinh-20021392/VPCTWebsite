using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.TaskModel;

namespace VPCT.Core.Config.MainModels.TaskModel
{
    public class AttachmentsConfig : IEntityTypeConfiguration<FileDinhKem>
    {
        public void Configure(EntityTypeBuilder<FileDinhKem> builder)
        {
            builder.ToTable(nameof(FileDinhKem));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.HasOne(x => x.Type).WithMany(x => x.FileDinhKem).HasForeignKey(x => x.FileTypeId);
            builder.HasOne(x => x.NhiemVu).WithMany(x => x.FileDinhKem).HasForeignKey(x => x.NhiemVuId);
        }
    }
}
