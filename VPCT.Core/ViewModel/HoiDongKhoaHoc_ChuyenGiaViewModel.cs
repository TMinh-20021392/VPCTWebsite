using VPCT.Core.Models.MainModels.TaskModel.Enums;

namespace VPCT.Core.ViewModel
{
    public class HoiDongKhoaHoc_ChuyenGiaViewModel
    {
        public int ChuyenGiaId { get; set; }
        public int HoiDongKhoaHocId { get; set; }
        public ChucDanhHoiDong ChucDanh { get; set; }
    }
}
