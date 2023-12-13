using VPCT.Core.Models.MainModels.ExpertModel;
using VPCT.Core.Models.MainModels.TaskModel;

namespace VPCT.Core.Models.MainModels.FieldModel
{
    public class LinhVuc
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public virtual ICollection<ChuyenNganh>? ChuyenNganhs { get; set; }
        public virtual ICollection<ChuyenGia>? ChuyenGia { get; set; }
        public virtual ICollection<NhiemVu>? NhiemVu { get; set; }
    }
}