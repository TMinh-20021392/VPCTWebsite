using VPCT.Core.Models.MainModels.TaskModel;
using VPCT.Repositories.Infrastructure;

namespace VPCT.Repositories.IRepositories.MainModels.TaskModel
{
    public interface ILanDieuChinhRepository : IBaseRepository<LanDieuChinh>
    {
        public IQueryable<LanDieuChinh> SearchLanDieuChinhByNhiemVuId(int nhiemVuId);

    }
}