using VPCT.Core.DbContext;
using VPCT.Core.Models.MainModels.ExpertModel;
using VPCT.Repositories.Infrastructure;
using VPCT.Repositories.IRepositories.MainModels.ExpertModel;

namespace VPCT.Repositories.Repositories.MainModels.ExpertModel
{
    public class GiaiThuongRepository(VPCTDbContext context) : BaseRepository<GiaiThuong>(context), IGiaiThuongRepository
    {
        public IQueryable<GiaiThuong> SearchGiaiThuongByChuyenGiaId(int chuyenGiaId)
        {
            return dataContext.GiaiThuong.Where(x => x.ChuyenGiaId == chuyenGiaId);
        }
    }
}
