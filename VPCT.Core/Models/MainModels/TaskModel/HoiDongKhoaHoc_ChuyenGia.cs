using VPCT.Core.Models.MainModels.ExpertModel;
using VPCT.Core.Models.MainModels.TaskModel.Enums;

namespace VPCT.Core.Models.MainModels.TaskModel
{
    public class HoiDongKhoaHoc_ChuyenGia
    {
        public int ChuyenGiaId { get; set; }
        public virtual ChuyenGia? ChuyenGia
        {
            get; set;
        }
        public int HoiDongKhoaHocId { get; set; }
        public virtual HoiDongKhoaHoc? HoiDongKhoaHoc
        {
            get; set;
        }
        public ChucDanhHoiDong ChucDanh { get; set; }
    }
}