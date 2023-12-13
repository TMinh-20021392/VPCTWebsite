using VPCT.Core.Models.MainModels.ProductModel;

namespace VPCT.Core.Models.MainModels.TaskModel
{
    public class OtherProducts : SanPham
    {
        public string? YeuCau { get; set; } //Yêu cầu khoa học cần đạt
        public string? GhiChu { get; set; } //Ghi chú sản phẩm
        public int NhiemVuId { get; set; }
        public virtual NhiemVu? NhiemVu { get; set; }
    }
}