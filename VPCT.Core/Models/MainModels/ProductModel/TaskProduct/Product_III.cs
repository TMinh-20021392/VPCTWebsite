using System.ComponentModel.DataAnnotations;
using VPCT.Core.Models.MainModels.TaskModel;

namespace VPCT.Core.Models.MainModels.ProductModel.TaskProduct
{
    public class Product_III : SanPham
    {
        [Required]
        public int LoaiSanPhamId { get; set; }
        public LoaiSanPham LoaiSanPham { get; set; } = null!; //Loại sản phẩm
        public string? YeuCau { get; set; } //Yêu cầu khoa học cần đạt
        public string? ExpectedPlace { get; set; } //Dự kiến nơi công bố (Tạp chí, Nhà xuất bản)
        public string? GhiChu { get; set; } //Ghi chú sản phẩm

        public int NhiemVuId { get; set; }
        public virtual NhiemVu? NhiemVu { get; set; }
    }
}
