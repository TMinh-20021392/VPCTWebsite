using VPCT.Core.DbContext;
using VPCT.Core.Models.MainModels.ExpertModel;
using VPCT.Repositories.Infrastructure;
using VPCT.Repositories.IRepositories;

namespace VPCT.Repositories.Repositories.MainModels.ExpertModel
{
    public class CongTrinhRepository(VPCTDbContext context) : BaseRepository<CongTrinh>(context), ICongTrinhRepository
    {
        public IQueryable<CongTrinh> SearchCongTrinhByChuyenGiaId(int chuyenGiaId)
        {
            return dataContext.CongTrinh.Where(x => x.ChuyenGiaId == chuyenGiaId);
        }
    }
}
