using System.ComponentModel.DataAnnotations;

namespace VPCT.Core.Models.MainModels.TaskModel.Enums
{
    public enum ChucDanhHoiDong
    {
        [Display(Name = "Chủ tịch")] President,
        [Display(Name = "Phó chủ tịch")] VicePresident,
        [Display(Name = "Thành viên")] Member
    }
}
