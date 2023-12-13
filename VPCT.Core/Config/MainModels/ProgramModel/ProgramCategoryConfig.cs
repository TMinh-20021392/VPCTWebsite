using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.ProgramModel;

namespace VPCT.Core.Config.MainModels.ProgramModel
{
    public class ProgramCategoryConfig : IEntityTypeConfiguration<LoaiChuongTrinh>
    {
        public void Configure(EntityTypeBuilder<LoaiChuongTrinh> builder)
        {
            builder.ToTable(nameof(LoaiChuongTrinh));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired();
        }
    }
}
