using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VPCT.Core.Models.DocAndFileTypes;

namespace VPCT.Core.Models.MainModels.TaskModel
{
    public class FileDinhKem
    {
        public int Id { get; set; }
        [Required]
        public int FileTypeId { get; set; }
        public virtual FileType? Type
        {
            get; set;
        }
        public string? GhiChu { get; set; }
        [Required]
        public string FileName { get; set; } = null!;
        [NotMapped]
        public IFormFile File { get; set; } = null!;
        [Required]
        public int NhiemVuId { get; set; }
        public virtual NhiemVu? NhiemVu
        {
            get; set;
        }
    }
}