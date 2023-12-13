using VPCT.Core.DbContext;
using VPCT.Core.Models.MainModels.TaskModel;
using VPCT.Repositories.Infrastructure;
using VPCT.Repositories.IRepositories;

namespace VPCT.Repositories.Repositories.MainModels.TaskModel
{
    public class CaNhanThamGiaRepository(VPCTDbContext context) : BaseRepository<CaNhanThamGia>(context), ICaNhanThamGiaRepository
    {
        public IQueryable<CaNhanThamGia> SearchCaNhanThamGiaByNhiemVuId(int nhiemVuId)
        {
            return dataContext.CaNhanThamGia.Where(x => x.NhiemVuId == nhiemVuId);
        }
    }
}
