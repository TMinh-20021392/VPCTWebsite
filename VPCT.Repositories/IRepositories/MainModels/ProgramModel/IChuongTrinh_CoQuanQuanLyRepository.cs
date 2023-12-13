using VPCT.Core.Models.MainModels.DepartmentModel;
using VPCT.Core.Models.MainModels.ProgramModel;
using VPCT.Repositories.Infrastructure;

namespace VPCT.Repositories.IRepositories.MainModels.ProgramModel
{
    public interface IChuongTrinh_CoQuanQuanLyRepository : IBaseRepository<ChuongTrinh_CoQuanQuanLy>
    {
        IQueryable<CoQuanQuanLy?> SearchCoQuanQuanLyByChuongTrinh(int ctId);
    }
}
