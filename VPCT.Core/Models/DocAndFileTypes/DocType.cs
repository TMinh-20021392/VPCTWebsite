using System.ComponentModel.DataAnnotations;
using VPCT.Core.Models.MainModels.TaskModel;

namespace VPCT.Core.Models.DocAndFileTypes
{
    public class DocType
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        public string? MoTa { get; set; }
        public virtual ICollection<CongVanNhiemVu>? CongVanNhiemVu { get; set; }
    }
}
