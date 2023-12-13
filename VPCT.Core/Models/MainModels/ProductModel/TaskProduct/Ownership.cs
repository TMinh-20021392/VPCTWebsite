using VPCT.Core.Models.MainModels.TaskModel;

namespace VPCT.Core.Models.MainModels.ProductModel.TaskProduct
{
    public class Ownership
    {
        public int Id { get; set; }
        public int LoaiSanPhamId { get; set; }
        public virtual LoaiSanPham? LoaiSanPham { get; set; }
        public string? Status { get; set; }
        public string? GhiChu { get; set; }
        public int NhiemVuId { get; set; }
        public virtual NhiemVu? NhiemVu { get; set; }
        public bool IsRegistered { get; set; } = false;
        public bool IsSucceeded { get; set; } = false;
        public bool IsOutstanding { get; set; } = false;
    }
}
