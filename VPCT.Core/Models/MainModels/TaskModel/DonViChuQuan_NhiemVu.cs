using VPCT.Core.Models.MainModels.DepartmentModel;
using VPCT.Core.Models.MainModels.TaskModel.Enums;

namespace VPCT.Core.Models.MainModels.TaskModel
{
    public class DonViChuQuan_NhiemVu
    {
        public int DonViChuQuanId { get; set; }
        public virtual DonViChuQuan? DonViChuQuan
        {
            get; set;
        }
        public int NhiemVuId { get; set; }
        public virtual NhiemVu? NhiemVu
        {
            get; set;
        }
        public LoaiHoSo? Filer { get; set; } //Loại hồ sơ
    }
}