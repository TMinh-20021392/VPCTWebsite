using System.ComponentModel.DataAnnotations;
using VPCT.Core.Models.MainModels.ProgramModel;
using VPCT.Core.Models.MainModels.TaskModel;

namespace VPCT.Core.Models.MainModels.DepartmentModel
{
    public class CoQuanQuanLy
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public LoaiQuanLy Type { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Fax { get; set; }
        public enum LoaiQuanLy
        {
            [Display(Name = "Quản lý kinh phí")] CostMangement,
            [Display(Name = "Quản lý nhiệm vụ")] TaskManagement
        }
        public virtual ICollection<NhiemVu>? CostManagingTasks { get; set; }
        public virtual ICollection<NhiemVu>? TaskManagingTasks { get; set; }
        public virtual ICollection<ChuongTrinh_CoQuanQuanLy>? ChuongTrinh_CoQuanQuanLys { get; set; }
    }
}
