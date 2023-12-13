using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.TaskModel;

namespace VPCT.Core.Config.MainModels.TaskModel
{
    public class DocumentsConfig : IEntityTypeConfiguration<CongVanNhiemVu>
    {
        public void Configure(EntityTypeBuilder<CongVanNhiemVu> builder)
        {
            builder.ToTable(nameof(CongVanNhiemVu));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.SoCongVan).IsRequired();
            builder.Property(x => x.TrichYeu).IsRequired();
            builder.HasOne(x => x.Type).WithMany(x => x.CongVanNhiemVu).HasForeignKey(x => x.DocTypeId);
            builder.HasOne(x => x.NhiemVu).WithMany(x => x.CongVanNhiemVu).HasForeignKey(x => x.NhiemVuId);
        }
    }
}
