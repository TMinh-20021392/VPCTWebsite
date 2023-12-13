using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.ProductModel.TaskProduct;
using VPCT.Core.Models.MainModels.TaskModel.Enums;

namespace VPCT.Core.Config.MainModels.ProductModel.TaskProduct
{
    public class Product_PostgraduateTrainingConfig : IEntityTypeConfiguration<Product_PostgraduateTraining>
    {
        public void Configure(EntityTypeBuilder<Product_PostgraduateTraining> builder)
        {
            builder.ToTable(nameof(Product_PostgraduateTraining));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.TrainingLevel).IsRequired()
                .HasConversion(
                    v => v.ToString(),
                    v => (CapDaoTao)Enum.Parse(typeof(CapDaoTao), v));
            builder.HasOne(x => x.NhiemVu).WithMany(x => x.Product_PostgraduateTrainings).HasForeignKey(x => x.NhiemVuId);
            builder.HasOne(x => x.ChuyenNganh).WithMany(x => x.Product_PostgraduateTraining).HasForeignKey(x => x.ChuyenNganhId);
        }
    }
}
