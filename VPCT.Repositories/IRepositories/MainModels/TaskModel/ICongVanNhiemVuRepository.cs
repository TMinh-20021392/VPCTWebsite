using VPCT.Core.Models.MainModels.TaskModel;

namespace VPCT.Repositories.Infrastructure
{
    public interface ICongVanNhiemVuRepository:IBaseRepository<CongVanNhiemVu>
    {
        public IQueryable<CongVanNhiemVu> SearchCongVanNhiemVuByNhiemVuId(int nhiemVuId);
    }
}