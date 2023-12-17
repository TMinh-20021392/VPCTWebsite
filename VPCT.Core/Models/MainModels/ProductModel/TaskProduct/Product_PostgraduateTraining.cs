using System.ComponentModel.DataAnnotations;
using VPCT.Core.Models.MainModels.FieldModel;
using VPCT.Core.Models.MainModels.TaskModel;
using VPCT.Core.Models.MainModels.TaskModel.Enums;

namespace VPCT.Core.Models.MainModels.ProductModel.TaskProduct
{
    public class Product_PostgraduateTraining
    {
        public int Id { get; set; }
        [Required]
        public CapDaoTao TrainingLevel { get; set; }
        public int? Number { get; set; } = 0; //Số lượng đào tạo
        public int? ChuyenNganhId { get; set; }
        public virtual ChuyenNganh? ChuyenNganh { get; set; }
        public string? GhiChu { get; set; }
        [Required]
        public int NhiemVuId { get; set; }
        public virtual NhiemVu? NhiemVu { get; set; }
        public bool IsRegistered { get; set; } = false;
        public bool IsSucceeded { get; set; } = false;
        public bool IsOutstanding { get; set; } = false;
    }
}
