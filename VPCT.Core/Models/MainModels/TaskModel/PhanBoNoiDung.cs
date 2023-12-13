namespace VPCT.Core.Models.MainModels.TaskModel
{
    public class PhanBoNoiDung
    {
        public int Id { get; set; }
        public string NoiDung { get; set; } = null!;
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public bool? IsCompleted { get; set; }
        public double? KinhPhi { get; set; }
        public string? GhiChu { get; set; }
        public int NhiemVuId { get; set; }
        public virtual NhiemVu? NhiemVu
        {
            get; set;
        }
    }
}