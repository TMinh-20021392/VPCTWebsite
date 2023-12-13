using VPCT.Core.Models.MainModels.TaskModel;
using VPCT.Repositories.Infrastructure;

namespace VPCT.Repositories.IRepositories
{
    public interface ICaNhanThamGiaRepository:IBaseRepository<CaNhanThamGia>
    {
        public IQueryable<CaNhanThamGia> SearchCaNhanThamGiaByNhiemVuId (int nhiemVuId);
    }
}