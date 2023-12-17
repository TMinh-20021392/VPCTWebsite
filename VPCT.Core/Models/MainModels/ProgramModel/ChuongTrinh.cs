using System.ComponentModel.DataAnnotations;
using VPCT.Core.Models.MainModels.DepartmentModel;
using VPCT.Core.Models.MainModels.ExpertModel;
using VPCT.Core.Models.MainModels.TaskModel;

namespace VPCT.Core.Models.MainModels.ProgramModel
{
    public class ChuongTrinh
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public string MaChuongTrinh { get; set; } = null!;
        [Required]
        public int LoaiChuongTrinhId { get; set; }
        public virtual LoaiChuongTrinh? LoaiChuongTrinh { get; set; }
        public int? StartYear { get; set; }
        public int? EndYear { get; set; }
        public double KinhPhi { get; set; } = 0;
        public int? CoQuanChuTriId { get; set; }
        public virtual CoQuanChuTri? CoQuanChuTri { get; set; }
        public string? Objective { get; set; } //Mục tiêu
        public string? NoiDung { get; set; } //Nội dung
        public string? Product { get; set; } //Sản phẩm
        public string? Criteria { get; set; } //Tiêu chí
        public string? GhiChu { get; set; } //Ghi chú
        public virtual ICollection<ChuyenGia>? ChuyenGia { get; set; }
        public virtual ICollection<NhiemVu>? NhiemVu { get; set; } = new List<NhiemVu>();
        public virtual ICollection<ChuongTrinh_CoQuanQuanLy>? ChuongTrinh_CoQuanQuanLys { get; set; }
        public bool IsPublished { get; set; } = false;

        /* Ban chủ nhiệm chương trình */
        public string? President { get; set; } //Chủ nhiệm
        public string? VicePresident { get; set; } //Phó chủ nhiệm
        public string? Member_Secretary { get; set; } //Ủy viên, thư ký khoa học
        public string? Member1 { get; set; }
        public string? Member2 { get; set; }
        public string? Member3 { get; set; }
        public string? Admin_Secretary { get; set; } //Thư ký hành chính
        public int? GiaiDoanId { get; set; }
        public virtual GiaiDoan? GiaiDoan { get; set; }
    }
}
