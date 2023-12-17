using System.ComponentModel.DataAnnotations;

namespace VPCT.Core.Models.MainModels.ProductModel
{
    public class DangSanPham
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        public string? MoTa { get; set; }
        public virtual ICollection<LoaiSanPham>? LoaiSanPham { get; set; }
    }
}
