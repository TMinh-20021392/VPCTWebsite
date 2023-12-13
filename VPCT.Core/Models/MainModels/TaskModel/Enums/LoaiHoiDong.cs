using System.ComponentModel.DataAnnotations;

namespace VPCT.Core.Models.MainModels.TaskModel.Enums
{
    public enum LoaiHoiDong
    {
        [Display(Name = "Nghiệm thu, đánh giá")] Evaluation,
        [Display(Name = "Tuyển chọn, xét tuyển")] Admission,
        [Display(Name = "Tư vấn")] Consulting
    }
}
