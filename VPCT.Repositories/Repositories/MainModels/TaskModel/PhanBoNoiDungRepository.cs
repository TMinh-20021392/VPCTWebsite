using VPCT.Core.DbContext;
using VPCT.Core.Models.MainModels.TaskModel;
using VPCT.Repositories.Infrastructure;

namespace VPCT.Repositories.Repositories.MainModels.TaskModel
{
    public class PhanBoNoiDungRepository(VPCTDbContext context) : BaseRepository<PhanBoNoiDung>(context), IPhanBoNoiDungRepository
    {
        public IQueryable<PhanBoNoiDung> SearchPhanBoNoiDungByNhiemVuId(int nhiemVuId)
        {
            return dataContext.PhanBoNoiDung.Where(x => x.NhiemVuId == nhiemVuId);
        }
    }
}
