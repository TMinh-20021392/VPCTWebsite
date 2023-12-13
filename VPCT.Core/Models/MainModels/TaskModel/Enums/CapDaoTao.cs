using System.ComponentModel.DataAnnotations;

namespace VPCT.Core.Models.MainModels.TaskModel.Enums
{
    public enum CapDaoTao
    {
        [Display(Name = "Thạc sĩ")] Ths,
        [Display(Name = "Tiến sĩ")] TS,
        [Display(Name = "Phó Giáo sư")] PGS,
    }
}
