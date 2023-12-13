using VPCT.Core.Models.MainModels.TaskModel.Enums;

namespace VPCT.Core.ViewModel
{
    public class CoQuanChuTri_NhiemVuViewModel
    {
        public int NhiemVuId { get; set; }
        public int CoQuanChuTriId { get; set; }
        public int DonViChuQuanId { get; set; }
        public LoaiHoSo? Filer { get; set; }
    }
}
