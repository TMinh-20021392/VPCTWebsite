using System.ComponentModel.DataAnnotations;
using VPCT.Core.Models.MainModels.ExpertModel;

namespace VPCT.Core.Models.MainModels.TaskModel
{
    public class CaNhanThamGia
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? HocHamId { get; set; }
        public virtual HocHam? HocHam { get; set; } //Học hàm
        public int? HocViId { get; set; }
        public virtual HocVi? HocVi { get; set; } //Học vị
        public string? Address { get; set; }
        [Required]
        public int NhiemVuId { get; set; }
        public virtual NhiemVu? NhiemVu { get; set; }
    }
}