using VPCT.Core.DbContext;
using VPCT.Core.Models.MainModels.ExpertModel;
using VPCT.Repositories.Infrastructure;
using VPCT.Repositories.IRepositories.MainModels.ExpertModel;

namespace VPCT.Repositories.Repositories.MainModels.ExpertModel
{
    public class VanBangRepository(VPCTDbContext context) : BaseRepository<VanBang>(context), IVanBangRepository
    {
        public IQueryable<VanBang> SearchVanBangByChuyenGiaId(int chuyenGiaId)
        {
            return dataContext.VanBang.Where(x => x.ChuyenGiaId == chuyenGiaId);
        }
    }
}
