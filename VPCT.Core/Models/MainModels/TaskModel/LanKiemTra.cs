namespace VPCT.Core.Models.MainModels.TaskModel
{
    public class LanKiemTra
    {
        public int Id { get; set; }
        public DateTime EstimatedTestDate { get; set; } //Ngày KT dự kiến
        public string? TesterName { get; set; } //Chuyên viên KT dự kiến
        public bool? HasTested { get; set; }
        public DateTime? TestDate { get; set; } //Ngày kiểm tra
        public string? NoiDung { get; set; } //Nội dung kiểm tra
        public double? FinalCost { get; set; } //Kinh phí quyết toán
        public string? KetLuan { get; set; } //Kết luận kiểm tra
        public int NhiemVuId { get; set; }
        public virtual NhiemVu? NhiemVu
        {
            get; set;
        }
    }
}