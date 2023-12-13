using VPCT.Core.Models.MainModels.TaskModel;

namespace VPCT.Core.Models.MainModels.ProductModel.TaskProduct
{
    public class ThanhLapDoanhNghiep
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? TenVietTat { get; set; }
        public string? Address { get; set; }
        public bool IsCompleted { get; set; } = false;
        public int NhiemVuId { get; set; }
        public virtual NhiemVu? NhiemVu { get; set; }
    }
}
