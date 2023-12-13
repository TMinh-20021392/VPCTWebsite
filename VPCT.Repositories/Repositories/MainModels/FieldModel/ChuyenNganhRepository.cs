using VPCT.Core.DbContext;
using VPCT.Core.Models.MainModels.FieldModel;
using VPCT.Repositories.Infrastructure;
using VPCT.Repositories.IRepositories;

namespace VPCT.Repositories.Repositories
{
    public class ChuyenNganhRepository(VPCTDbContext context) : BaseRepository<ChuyenNganh>(context), IChuyenNganhRepository
    {
        public IQueryable<ChuyenNganh> SearchChuyenNganhByLinhVucId(int linhVucId)
        {
            return dataContext.ChuyenNganh.Where(x => x.LinhVucId == linhVucId);
        }
    }
}
