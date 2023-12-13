using VPCT.Core.DbContext;
using VPCT.Core.Models.MainModels.TaskModel;
using VPCT.Repositories.Infrastructure;
using VPCT.Repositories.IRepositories.MainModels.TaskModel;

namespace VPCT.Repositories.Repositories
{
    public class LanKiemTraRepository(VPCTDbContext context) : BaseRepository<LanKiemTra>(context), ILanKiemTraRepository
    {
        public IQueryable<LanKiemTra> SearchLanKiemTraByNhiemVuId(int nhiemVuId)
        {
            return dataContext.LanKiemTra.Where(x => x.NhiemVuId == nhiemVuId);
        }
    }
}
