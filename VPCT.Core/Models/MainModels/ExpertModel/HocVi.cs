using VPCT.Core.Models.MainModels.TaskModel;

namespace VPCT.Core.Models.MainModels.ExpertModel
{
    public class HocVi
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public virtual ICollection<ChuyenGia>? ChuyenGia { get; set; }
        public virtual ICollection<CaNhanThamGia>? CaNhanThamGia { get; set; }
    }
}
