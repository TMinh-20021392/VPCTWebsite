using System.ComponentModel.DataAnnotations;
using VPCT.Core.Models.MainModels.ExpertModel;
using VPCT.Core.Models.MainModels.TaskModel;

namespace VPCT.Core.Models.MainModels.DepartmentModel
{
    public class DonViChuQuan
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        public virtual ICollection<DonViChuQuan_NhiemVu>? DonViChuQuan_NhiemVu { get; set; }
        public virtual ICollection<CoQuanChuTri>? CoQuanChuTri { get; set; }
        public virtual ICollection<ChuyenGia>? ChuyenGia { get; set; }
        public virtual ICollection<CoQuanChuTri_NhiemVu>? CoQuanChuTri_NhiemVu { get; set; }
    }
}