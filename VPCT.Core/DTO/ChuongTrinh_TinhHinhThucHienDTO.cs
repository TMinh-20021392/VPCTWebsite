namespace VPCT.Core.DTO
{
    public class ChuongTrinh_TinhHinhThucHienDTO
    {
        public string MaChuongTrinh { get; set; }
        public int TaskCount { get; set; }
        public double? ChuyenMon_Total { get; set; }
        public double? VatLieuThietBi_Total { get; set; }
        public double? HTQT_Total { get; set; }
        public double? KinhPhiThuHoi { get; set; }
        public double? KinhPhiNguonKhac_Total { get; set; }
        public List<HocVi_CountDTO> HocVi_CountDTOs { get; set; }
        public int CoQuanChuTri_NghienCuuCount { get; set; }
        public int CoQuanChuTri_DoanhNghiepCount { get; set; }
    }
}
