using VPCT.Core.Models.MainModels.DepartmentModel;
using static VPCT.Core.Models.MainModels.DepartmentModel.CoQuanQuanLy;

namespace VPCT.Repositories.Infrastructure
{
    public interface ICoQuanQuanLyRepository:IBaseRepository<CoQuanQuanLy>
    {
        IQueryable<CoQuanQuanLy> SearchCoQuanQuanLyByLoaiQuanLy(LoaiQuanLy loaiQuanLy);
    }
}