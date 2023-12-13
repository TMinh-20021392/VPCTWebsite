using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.ProductModel;

namespace VPCT.Core.Config.MainModels.ProductModel
{
    public class ProductCategoryConfig : IEntityTypeConfiguration<DangSanPham>
    {
        public void Configure(EntityTypeBuilder<DangSanPham> builder)
        {
            builder.ToTable(nameof(DangSanPham));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired();
        }
    }
}
