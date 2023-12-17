using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VPCT.Core.Models.MainModels.DepartmentModel;
using VPCT.Core.Models.MainModels.FieldModel;
using VPCT.Core.Models.MainModels.ProgramModel;
using VPCT.Core.Models.MainModels.TaskModel;

namespace VPCT.Core.Models.MainModels.ExpertModel
{
    public class ChuyenGia
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        public int? ChuongTrinhId { get; set; }
        public virtual ChuongTrinh? ChuongTrinh { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool? Gender { get; set; }
        public string? ImageName { get; set; }
        [NotMapped]
        public IFormFile? ImageFile { get; set; }
        [NotMapped]
        public string? ImageSrc { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? Stk { get; set; } //Số tài khoản
        public string? Bank { get; set; } //Ngân hàng
        public int? ChucDanhId { get; set; }
        public virtual ChucDanh? ChucDanh { get; set; } //Chức danh
        public int? HocHamId { get; set; }
        public virtual HocHam? HocHam { get; set; } //Học hàm
        public int? ChucVuId { get; set; }
        public virtual ChucVu? ChucVu { get; set; } //Chức vụ
        public int? HocViId { get; set; }
        public virtual HocVi? HocVi { get; set; } //Học vị
        public int? CoQuanChuTriId { get; set; }
        public virtual CoQuanChuTri? CoQuanChuTri { get; set; } //Cơ quan chủ trì
        public int? DonViChuQuanId { get; set; }
        public virtual DonViChuQuan? DonViChuQuan { get; set; } //Bộ hoặc Đơn vị chủ quản
        public int? ChuyenNganhId { get; set; }
        public virtual ChuyenNganh? ChuyenNganh { get; set; } //Chuyên ngành
        public int? LinhVucId { get; set; }
        public virtual LinhVuc? LinhVuc { get; set; } //Lĩnh vực
        public string? Ex_Info_Participation { get; set; } //Tên các hiệp hội, tổ chức nghề nghiệp khác đã tham gia
        public string? Ex_Info_Field { get; set; } //Các lĩnh vực đã tham gia tư vấn cho Bộ KHCN và các bộ ngành khác
        public virtual ICollection<HoiDongKhoaHoc_ChuyenGia>? HoiDongKhoaHoc_ChuyenGia { get; set; }
        public virtual ICollection<GiaiThuong>? GiaiThuong { get; set; }
        public virtual ICollection<KinhNghiem>? KinhNghiem { get; set; }
        public virtual ICollection<AnPham>? AnPham { get; set; }
        public virtual ICollection<VanBang>? VanBang { get; set; }
        public virtual ICollection<CongTrinh>? CongTrinh { get; set; }
        public virtual ICollection<HoatDongKhac>? HoatDongKhac { get; set; }
        public virtual ICollection<NhiemVu>? NhiemVu { get; set; }
    }
}
