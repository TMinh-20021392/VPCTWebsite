using VPCT.Core.DbContext;
using VPCT.Core.Models.MainModels.TaskModel;
using VPCT.Repositories.Infrastructure;

namespace VPCT.Repositories.Repositories.MainModels.TaskModel
{
    public class FileDinhKemRepository(VPCTDbContext context) : BaseRepository<FileDinhKem>(context), IFileDinhKemRepository
    {
        public IQueryable<FileDinhKem> SearchFileDinhKemByNhiemVuId(int nhiemVuId)
        {
            return dataContext.FileDinhKem.Where(x => x.NhiemVuId == nhiemVuId);
        }
    }
}
