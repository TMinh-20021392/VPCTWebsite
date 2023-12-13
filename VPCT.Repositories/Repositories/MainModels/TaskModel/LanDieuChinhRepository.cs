using VPCT.Core.DbContext;
using VPCT.Core.Models.MainModels.TaskModel;
using VPCT.Repositories.Infrastructure;
using VPCT.Repositories.IRepositories.MainModels.TaskModel;

namespace VPCT.Repositories.Repositories.MainModels.TaskModel
{
    public class LanDieuChinhRepository(VPCTDbContext context) : BaseRepository<LanDieuChinh>(context), ILanDieuChinhRepository
    {
        public IQueryable<LanDieuChinh> SearchLanDieuChinhByNhiemVuId(int nhiemVuId)
        {
            return dataContext.LanDieuChinh.Where(x=>x.NhiemVuId == nhiemVuId); 
        }
    }
}
