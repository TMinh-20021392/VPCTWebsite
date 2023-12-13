using System.ComponentModel.DataAnnotations;

namespace VPCT.Core.Models.MainModels.TaskModel.Enums
{
    public enum KetQua
    {
        [Display(Name = "Chưa có kết quả")] None,
        [Display(Name = "Không đạt")] Failed,
        [Display(Name = "Trung bình")] Average,
        [Display(Name = "Khá")] Good,
        [Display(Name = "Xuất sắc")] Excellent
    }
}
