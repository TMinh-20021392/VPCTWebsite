using System.ComponentModel.DataAnnotations;
using VPCT.Core.Models.MainModels.ExpertModel;
using VPCT.Core.Models.MainModels.ProductModel.TaskProduct;
using VPCT.Core.Models.MainModels.TaskModel;

namespace VPCT.Core.Models.MainModels.FieldModel
{
    public class ChuyenNganh
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public int LinhVucId { get; set; }
        public virtual LinhVuc? LinhVuc { get; set; }
        public virtual ICollection<ChuyenGia>? ChuyenGia { get; set; }
        public virtual ICollection<Product_PostgraduateTraining>? Product_PostgraduateTraining { get; set; }
        public virtual ICollection<NhiemVu>? NhiemVu { get; set; }
    }
}