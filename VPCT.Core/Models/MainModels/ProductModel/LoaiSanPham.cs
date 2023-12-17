using System.ComponentModel.DataAnnotations;
using VPCT.Core.Models.MainModels.ProductModel.TaskProduct;

namespace VPCT.Core.Models.MainModels.ProductModel
{
    public class LoaiSanPham
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        public int? DangSanPhamId { get; set; }
        public virtual DangSanPham? DangSanPham { get; set; }
        public virtual ICollection<Ownership>? Ownership { get; set; }
        public virtual ICollection<Product_I>? Product_Is { get; set; }
        public virtual ICollection<Product_II>? Product_IIs { get; set; }
        public virtual ICollection<Product_III>? Product_IIIs { get; set; }
    }
}
