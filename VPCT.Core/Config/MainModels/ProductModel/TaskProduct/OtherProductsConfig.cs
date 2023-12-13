using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.TaskModel;

namespace VPCT.Core.Config.MainModels.ProductModel.TaskProduct
{
    public class OtherProductsConfig : IEntityTypeConfiguration<OtherProducts>
    {
        public void Configure(EntityTypeBuilder<OtherProducts> builder)
        {
            builder.ToTable(nameof(OtherProducts));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired();
            builder.HasOne(x => x.NhiemVu).WithMany(x => x.OtherProducts).HasForeignKey(x => x.NhiemVuId);
        }
    }
}
