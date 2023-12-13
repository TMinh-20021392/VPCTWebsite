using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.ProductModel.TaskProduct;

namespace VPCT.Core.Config.MainModels.ProductModel.TaskProduct
{
    public class Product_IConfig : IEntityTypeConfiguration<Product_I>
    {
        public void Configure(EntityTypeBuilder<Product_I> builder)
        {
            builder.ToTable(nameof(Product_I));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired();
            builder.HasOne(x => x.NhiemVu).WithMany(x => x.Product_Is).HasForeignKey(x => x.NhiemVuId);
            builder.HasOne(x => x.LoaiSanPham).WithMany(x => x.Product_Is).HasForeignKey(x => x.LoaiSanPhamId);
        }
    }
}
