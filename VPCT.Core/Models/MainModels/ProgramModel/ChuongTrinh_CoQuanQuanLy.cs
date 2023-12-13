using VPCT.Core.Models.MainModels.DepartmentModel;

namespace VPCT.Core.Models.MainModels.ProgramModel
{
    public class ChuongTrinh_CoQuanQuanLy
    {
        public int ChuongTrinhId { get; set; }
        public virtual ChuongTrinh? ChuongTrinh { get; set; }
        public int CoQuanQuanLyId { get; set; }
        public virtual CoQuanQuanLy? CoQuanQuanLy { get; set; }
    }
}
