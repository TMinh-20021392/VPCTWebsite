using VPCT.Core.Models.MainModels.TaskModel;
using VPCT.Repositories.Infrastructure;

namespace VPCT.Repositories.IRepositories.MainModels.TaskModel
{
    public interface ILanKiemTraRepository : IBaseRepository<LanKiemTra>
    {
        public IQueryable<LanKiemTra> SearchLanKiemTraByNhiemVuId(int nhiemVuId);
    }
}