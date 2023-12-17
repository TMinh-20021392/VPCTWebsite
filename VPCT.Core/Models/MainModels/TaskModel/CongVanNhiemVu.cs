using System.ComponentModel.DataAnnotations;
using VPCT.Core.Models.DocAndFileTypes;

namespace VPCT.Core.Models.MainModels.TaskModel
{
    public class CongVanNhiemVu
    {
        public int Id { get; set; } 
        public string SoCongVan { get; set; } = null!;
        public string TrichYeu { get; set; } = null!;
        public DateTime? PublishedDate { get; set; }
        public int? DocTypeId { get; set; }
        public virtual DocType? Type { get; set; }
        public string? NoiDung { get; set; }
        [Required]
        public int NhiemVuId { get; set; }
        public virtual NhiemVu? NhiemVu { get; set; }
    }
}