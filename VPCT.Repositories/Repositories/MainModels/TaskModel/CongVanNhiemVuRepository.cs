using VPCT.Core.DbContext;
using VPCT.Core.Models.MainModels.TaskModel;
using VPCT.Repositories.Infrastructure;

namespace VPCT.Repositories.Repositories.MainModels.TaskModel
{
    public class CongVanNhiemVuRepository(VPCTDbContext context) : BaseRepository<CongVanNhiemVu>(context), ICongVanNhiemVuRepository
    {
        public IQueryable<CongVanNhiemVu> SearchCongVanNhiemVuByNhiemVuId(int nhiemVuId)
        {
            return dataContext.CongVanNhiemVu.Where(x => x.NhiemVuId == nhiemVuId);
        }
    }
}
