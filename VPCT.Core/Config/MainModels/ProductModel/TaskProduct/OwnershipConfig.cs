using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.ProductModel.TaskProduct;

namespace VPCT.Core.Config.MainModels.ProductModel.TaskProduct
{
    public class OwnershipConfig : IEntityTypeConfiguration<Ownership>
    {
        public void Configure(EntityTypeBuilder<Ownership> builder)
        {
            builder.ToTable(nameof(Ownership));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.HasOne(x => x.NhiemVu).WithMany(x => x.Ownerships).HasForeignKey(x => x.NhiemVuId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x=>x.LoaiSanPham).WithMany(x=>x.Ownership).HasForeignKey(x => x.LoaiSanPhamId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
