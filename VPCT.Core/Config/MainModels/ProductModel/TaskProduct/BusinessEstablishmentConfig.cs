using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.ProductModel.TaskProduct;

namespace VPCT.Core.Config.MainModels.ProductModel.TaskProduct
{
    public class BusinessEstablishmentConfig : IEntityTypeConfiguration<ThanhLapDoanhNghiep>
    {
        public void Configure(EntityTypeBuilder<ThanhLapDoanhNghiep> builder)
        {
            builder.ToTable(nameof(ThanhLapDoanhNghiep));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired();
            builder.HasOne(x => x.NhiemVu).WithMany(x => x.ThanhLapDoanhNghiep).HasForeignKey(x => x.NhiemVuId);
        }
    }
}
