using System.ComponentModel.DataAnnotations;

namespace VPCT.Core.Models.MainModels.TaskModel.Enums
{
    public enum TrangThaiNhiemVu
    {
        [Display(Name = "Thực hiện")] Working,
        [Display(Name = "Dừng")] Cancelled,
        [Display(Name = "Đã nghiệm thu")] Completed
    }
}
