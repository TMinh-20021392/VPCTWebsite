using System.ComponentModel.DataAnnotations;

namespace VPCT.Core.Models.MainModels.TaskModel.Enums
{
    public enum LoaiHoSo
    {
        [Display(Name = "Hồ sơ")] File,
        [Display(Name = "Hiện tại")] Current,
    }
}