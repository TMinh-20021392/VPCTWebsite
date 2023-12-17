using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VPCT.Core.Models.MainModels.DepartmentModel;
using VPCT.Core.Models.MainModels.ExpertModel;
using VPCT.Core.Models.MainModels.FieldModel;
using VPCT.Core.Models.MainModels.ProductModel.TaskProduct;
using VPCT.Core.Models.MainModels.ProgramModel;
using VPCT.Core.Models.MainModels.TaskModel.Enums;

namespace VPCT.Core.Models.MainModels.TaskModel
{
    public class NhiemVu
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public string MaNhiemVu { get; set; } = null!;
        [Required]
        public LoaiNhiemVu Category { get; set; }
        [Required]
        public int PresidentId { get; set; }
        public virtual ChuyenGia? President
        {
            get; set;
        } //Chủ nhiệm đề tài, dự án
        public int? ChuongTrinhId { get; set; }
        public virtual ChuongTrinh? ChuongTrinh { get; set; }

        /* Navbar */
        public virtual ICollection<HoiDongKhoaHoc>? HoiDongKhoaHoc { get; set; } //Hội đồng khoa học
        public virtual ICollection<DonViChuQuan_NhiemVu>? DonViChuQuan_NhiemVu { get; set; } //Đơn vị chủ quản
        public virtual ICollection<CoQuanChuTri_NhiemVu>? CoQuanChuTri_NhiemVu { get; set; } //Cơ quan phối hợp
        public virtual ICollection<CaNhanThamGia>? CaNhanThamGia { get; set; } //Cá nhân tham gia
        public virtual ICollection<Product_I>? Product_Is { get; set; }
        public virtual ICollection<Product_II>? Product_IIs { get; set; }
        public virtual ICollection<Product_III>? Product_IIIs { get; set; }
        public virtual ICollection<Product_PostgraduateTraining>? Product_PostgraduateTrainings { get; set; }
        public virtual ICollection<Ownership>? Ownerships { get; set; }
        public virtual ICollection<OtherProducts>? OtherProducts { get; set; }
        public virtual ICollection<ThanhLapDoanhNghiep>? ThanhLapDoanhNghiep { get; set; }
        public virtual ICollection<LanKiemTra>? LanKiemTra { get; set; }
        public virtual ICollection<LanDieuChinh>? LanDieuChinh { get; set; }
        public virtual ICollection<FileDinhKem>? FileDinhKem { get; set; }
        public virtual ICollection<CongVanNhiemVu>? CongVanNhiemVu { get; set; }
        public virtual ICollection<PhanBoNoiDung>? PhanBoNoiDung { get; set; }

        /* Thông tin chung */
        [Required]
        public TrangThaiNhiemVu Status { get; set; }
        public int? CoQuanChuTriId { get; set; }
        public virtual CoQuanChuTri? CoQuanChuTri { get; set; }
        public int? LinhVucId { get; set; }
        public virtual LinhVuc? LinhVuc { get; set; }
        public int? ChuyenNganhId { get; set; }
        public virtual ChuyenNganh? ChuyenNganh { get; set; }

        public int? StartDate_Month { get; set; }
        public int? StartDate_Year { get; set; }

        public int? EndDate_Month { get; set; }
        public int? EndDate_Year { get; set; }

        public int? NgiemThu_Month { get; set; }
        public int? NgiemThu_Year { get; set; }

        public int? CoQuanQuanLyKinhPhiId { get; set; }
        public virtual CoQuanQuanLy? CoQuanQuanLyKinhPhi { get; set; }
        public string? VPCT_Leader { get; set; } //Lãnh đạo VPCT phụ trách
        public string? Accounting_Specialist { get; set; } //Chuyên viên kế toán phụ trách
        public string? Planning_Specialist { get; set; } //Chuyên viên tổng hợp kế hoạch phụ trách

        public int? CoQuanQuanLyNhiemVuId { get; set; }
        public virtual CoQuanQuanLy? CoQuanQuanLyNhiemVu { get; set; }
        public string? DepartmentAdmin { get; set; } //Vụ chuyên ngành phụ trách
        public string? DepartmentAdminSpecialist { get; set; } //Chuyên viên vụ chuyên ngành phụ trách

        /* Mục tiêu & Nội dung */
        public string? MucTieu { get; set; } //Mục tiêu
        public string? NoiDung { get; set; } //Nội dung

        /* Kinh phí */
        /* Kế hoach cấp kinh phí */
        public int? FundingPlan_FirstYearMonths { get; set; }
        public int? FundingPlan_SecondYearMonths { get; set; }
        public int? FundingPlan_ThirdYearMonths { get; set; }
        public int? FundingPlan_FourthYearMonths { get; set; }
        public int? FundingPlan_FifteenYearMonths { get; set; }
        public int? FundingPlan_SixthYearMonths { get; set; }
        public double? FundingPlan_FirstYear { get; set; } //Kế hoach cấp kinh phí Năm thứ nhất
        public double? FundingPlan_SecondYear { get; set; }
        public double? FundingPlan_ThirdYear { get; set; }
        public double? FundingPlan_FourthYear { get; set; }
        public double? FundingPlan_FifthYear { get; set; }
        public double? FundingPlan_SixthYear { get; set; }

        public double? ThueKhoanChuyenMon_NganSachNhaNuoc { get; set; } = 0; //Thuê khoán chuyên môn(Đề tài)
        public double? ThueKhoanChuyenMon_Khac { get; set; } = 0;
        public double? HoTroCongNghe_NganSachNhaNuoc { get; set; } = 0;
        public double? HoTroCongNghe_Khac { get; set; } = 0;
        public double? ChiPhiLaoDong_NganSachNhaNuoc { get; set; } = 0;
        public double? ChiPhiLaoDong_Khac { get; set; } = 0;
        public double? NguyenVatLieu_NganSachNhaNuoc { get; set; } = 0;
        public double? NguyenVatLieu_Khac { get; set; } = 0;
        public double? ThietBiMayMoc_NganSachNhaNuoc { get; set; } = 0;
        public double? ThietBiMayMoc_Khac { get; set; } = 0;
        public double? MuaMoi_NganSachNhaNuoc { get; set; } = 0;
        public double? MuaMoi_Khac { get; set; } = 0;
        public double? Thue_NganSachNhaNuoc { get; set; } = 0;
        public double? Thue_Khac { get; set; } = 0;
        public double? XayDungSuaChuaNho_NganSachNhaNuoc { get; set; } = 0;
        public double? XayDungSuaChuaNho_Khac { get; set; } = 0;
        public double? ChiPhiKhac_NganSachNhaNuoc { get; set; } = 0;
        public double? ChiPhiKhac_Khac { get; set; } = 0;
        public double? HTQT_NganSachNhaNuoc { get; set; } = 0;
        public double? HTQT_Khac { get; set; } = 0;

        [NotMapped]
        public double? NganSachNhaNuoc_Total
        {
            get
            {
                return ThueKhoanChuyenMon_NganSachNhaNuoc +
                       HoTroCongNghe_NganSachNhaNuoc +
                       ChiPhiLaoDong_NganSachNhaNuoc +
                       NguyenVatLieu_NganSachNhaNuoc +
                       ThietBiMayMoc_NganSachNhaNuoc +
                       MuaMoi_NganSachNhaNuoc +
                       Thue_NganSachNhaNuoc +
                       XayDungSuaChuaNho_NganSachNhaNuoc +
                       ChiPhiKhac_NganSachNhaNuoc;
            }
        }

        [NotMapped]
        public double? Khac_Total
        {
            get
            {
                return ThueKhoanChuyenMon_Khac +
                       HoTroCongNghe_Khac +
                       ChiPhiLaoDong_Khac +
                       NguyenVatLieu_Khac +
                       ThietBiMayMoc_Khac +
                       MuaMoi_Khac +
                       Thue_Khac +
                       XayDungSuaChuaNho_Khac +
                       ChiPhiKhac_Khac;
            }
        }
        [NotMapped]
        public double? KinhPhi_Total
        {
            get
            {
                return NganSachNhaNuoc_Total +
                       Khac_Total;
            }
        }

        /* Thực tế cấp kinh phí */
        public int? ThucTeCapKinhPhi_FirstYear_FirstTime_Month { get; set; }
        public int? ThucTeCapKinhPhi_FirstYear_FirstTime_Year { get; set; }
        public double? ThucTeCapKinhPhi_FirstYear_FirstTime { get; set; }

        public int? ThucTeCapKinhPhi_FirstYear_SecondTime_Month { get; set; }
        public int? ThucTeCapKinhPhi_FirstYear_SecondTime_Year { get; set; }
        public double? ThucTeCapKinhPhi_FirstYear_SecondTime { get; set; }

        public int? ThucTeCapKinhPhi_SecondYear_FirstTime_Month { get; set; }
        public int? ThucTeCapKinhPhi_SecondYear_FirstTime_Year { get; set; }
        public double? ThucTeCapKinhPhi_SecondYear_FirstTime { get; set; }

        public int? ThucTeCapKinhPhi_SecondYear_SecondTime_Month { get; set; }
        public int? ThucTeCapKinhPhi_SecondYear_SecondTime_Year { get; set; }
        public double? ThucTeCapKinhPhi_SecondYear_SecondTime { get; set; }

        public int? ThucTeCapKinhPhi_ThirdYear_FirstTime_Month { get; set; }
        public int? ThucTeCapKinhPhi_ThirdYear_FirstTime_Year { get; set; }
        public double? ThucTeCapKinhPhi_ThirdYear_FirstTime { get; set; }

        public int? ThucTeCapKinhPhi_ThirdYear_SecondTime_Month { get; set; }
        public int? ThucTeCapKinhPhi_ThirdYear_SecondTime_Year { get; set; }
        public double? ThucTeCapKinhPhi_ThirdYear_SecondTime { get; set; }

        public int? ThucTeCapKinhPhi_FourthYear_FirstTime_Month { get; set; }
        public int? ThucTeCapKinhPhi_FourthYear_FirstTime_Year { get; set; }
        public double? ThucTeCapKinhPhi_FourthYear_FirstTime { get; set; }

        public int? ThucTeCapKinhPhi_FourthYear_SecondTime_Month { get; set; }
        public int? ThucTeCapKinhPhi_FourthYear_SecondTime_Year { get; set; }
        public double? ThucTeCapKinhPhi_FourthYear_SecondTime { get; set; }

        public int? ThucTeCapKinhPhi_FifthYear_FirstTime_Month { get; set; }
        public int? ThucTeCapKinhPhi_FifthYear_FirstTime_Year { get; set; }
        public double? ThucTeCapKinhPhi_FifthYear_FirstTime { get; set; }

        public int? ThucTeCapKinhPhi_FifthYear_SecondTime_Month { get; set; }
        public int? ThucTeCapKinhPhi_FifthYear_SecondTime_Year { get; set; }
        public double? ThucTeCapKinhPhi_FifthYear_SecondTime { get; set; }

        public int? ThucTeCapKinhPhi_SixthYear_FirstTime_Month { get; set; }
        public int? ThucTeCapKinhPhi_SixthYear_FirstTime_Year { get; set; }
        public double? ThucTeCapKinhPhi_SixthYear_FirstTime { get; set; }

        public int? ThucTeCapKinhPhi_SixthYear_SecondTime_Month { get; set; }
        public int? ThucTeCapKinhPhi_SixthYear_SecondTime_Year { get; set; }
        public double? ThucTeCapKinhPhi_SixthYear_SecondTime { get; set; }

        /* Thu hồi kinh phí */
        public double? TongKinhPhiThuHoi { get; set; }

        [NotMapped]
        public double? TiLeThuHoi
        {
            get
            {
                if (KinhPhi_Total.HasValue && TongKinhPhiThuHoi.HasValue && KinhPhi_Total.Value != 0)
                {
                    return (TongKinhPhiThuHoi.Value / KinhPhi_Total.Value) * 100;
                }
                return null;
            }
        }

        public int? ThuHoiKinhPhi_FirstTime_Month { get; set; }
        public int? ThuHoiKinhPhi_FirstTime_Year { get; set; }
        public double? ThuHoiKinhPhi_FirstTime { get; set; }

        public int? ThuHoiKinhPhi_SecondTime_Month { get; set; }
        public int? ThuHoiKinhPhi_SecondTime_Year { get; set; }
        public double? ThuHoiKinhPhi_SecondTime { get; set; }

        /* Địa chỉ */
        public string? Address { get; set; }

        /* Hiệu quả */
        public string? HieuQua { get; set; } //Hiệu quả kinh tế xã hội

        /* Nghiệm thu */
        public KetQua? KetQua { get; set; }
        public string? NhanXet { get; set; } //Nhận xét của ban chủ nhiệm

        /* Thanh lý */
        public bool? ThanhLyTaiSan { get; set; }
        public string? PhuongAnThanhLyTaiSan { get; set; } //Phương án thanh lý tài sản
        public bool? ThanhLyHopDong { get; set; }
        public string? PhuongAnThanhLyHopDong { get; set; } //Phương án thanh lý hợp đồng
    }
}
