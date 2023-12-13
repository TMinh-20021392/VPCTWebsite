using VPCT.Core.Models.MainModels.ExpertModel;
using VPCT.Core.Models.MainModels.ProgramModel;
using VPCT.Core.Models.MainModels.TaskModel;
using NhiemVu = VPCT.Core.Models.MainModels.TaskModel.NhiemVu;

namespace VPCT.Core.Models.MainModels.DepartmentModel
{
    public class CoQuanChuTri
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool? IsEnterprise { get; set; } //Doanh nghiệp/Cơ quan nghiên cứu
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Fax { get; set; }
        public int DonViChuQuanId { get; set; }
        public virtual DonViChuQuan? DonViChuQuan { get; set; }
        public virtual ICollection<CoQuanChuTri_NhiemVu>? CoQuanChuTri_NhiemVu { get; set; }
        public virtual ICollection<ChuyenGia>? ChuyenGia { get; set; }
        public virtual ICollection<NhiemVu>? NhiemVu { get; set; }
        public virtual ICollection<ChuongTrinh>? ChuongTrinh { get; set; }
    }
}