using System.ComponentModel.DataAnnotations;
using VPCT.Core.Models.MainModels.TaskModel.Enums;

namespace VPCT.Core.Models.MainModels.TaskModel
{
    public class HoiDongKhoaHoc
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public LoaiHoiDong Category { get; set; }
        public ICollection<HoiDongKhoaHoc_ChuyenGia>? HoiDongKhoaHoc_ChuyenGia { get; set; }
        [Required]
        public int NhiemVuId { get; set; }
        public virtual NhiemVu? NhiemVu
        {
            get; set;
        }
    }
}
