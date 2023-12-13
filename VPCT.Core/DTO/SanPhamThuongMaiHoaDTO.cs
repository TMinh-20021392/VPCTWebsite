namespace VPCT.Core.DTO
{
    public class SanPhamThuongMaiHoaDTO
    {
        public string MaNhiemVu { get; set; }
        public int? SoLuongTieuThu { get; set; }
        public double? SoTienTieuThu { get; set; }
        public int? SoLuongChuyenGiao { get; set; }
        public double? SoTienChuyenGiao { get; set; }
        public int? SoHopDongDichVu { get; set; }
        public double? SoTienDichVu { get; set; }
        public int SoDoanhNghiep { get; set; }
        public string? TenDoanhNghiep { set; get; }
    }
}
