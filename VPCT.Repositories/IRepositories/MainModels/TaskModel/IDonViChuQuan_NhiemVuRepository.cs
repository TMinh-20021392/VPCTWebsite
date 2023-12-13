using VPCT.Core.Models.MainModels.TaskModel;
using VPCT.Repositories.Infrastructure;

namespace VPCT.Repositories.IRepositories
{
    public interface IDonViChuQuan_NhiemVuRepository:IBaseRepository<DonViChuQuan_NhiemVu>
    {
        public IQueryable<DonViChuQuan_NhiemVu> SearchDonViChuQuan_NhiemVuByNhiemVuId(int nhiemVuId);
    }
}