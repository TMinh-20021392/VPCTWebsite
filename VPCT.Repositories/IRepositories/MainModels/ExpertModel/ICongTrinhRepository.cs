using VPCT.Core.Models.MainModels.ExpertModel;
using VPCT.Repositories.Infrastructure;

namespace VPCT.Repositories.IRepositories
{
    public interface ICongTrinhRepository:IBaseRepository<CongTrinh>
    {
        IQueryable<CongTrinh> SearchCongTrinhByChuyenGiaId(int chuyenGiaId);
    }
}