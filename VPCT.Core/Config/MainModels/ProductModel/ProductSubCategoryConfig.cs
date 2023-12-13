using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.ProductModel;

namespace VPCT.Core.Config
{
    public class ProductSubCategoryConfig : IEntityTypeConfiguration<LoaiSanPham>
    {
        public void Configure(EntityTypeBuilder<LoaiSanPham> builder)
        {
            builder.ToTable(nameof(LoaiSanPham));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired();
            builder.HasOne(x => x.DangSanPham).WithMany(x => x.LoaiSanPham).HasForeignKey(x => x.DangSanPhamId);
        }
    }
}
