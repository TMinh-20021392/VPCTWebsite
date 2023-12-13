using System.ComponentModel.DataAnnotations;

namespace VPCT.Core.Models.MainModels.TaskModel.Enums
{
    public enum LoaiNhiemVu
    {
        [Display(Name = "Đề tài")] Topic,
        [Display(Name = "Dự án")] Project
    }
}
