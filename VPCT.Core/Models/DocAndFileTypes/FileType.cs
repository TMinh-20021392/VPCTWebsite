using VPCT.Core.Models.MainModels.TaskModel;

namespace VPCT.Core.Models.DocAndFileTypes
{
    public class FileType
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? MoTa { get; set; }
        public virtual ICollection<FileDinhKem>? FileDinhKem { get; set; }   
    }
}
