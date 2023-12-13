using VPCT.Core.DbContext;
using VPCT.Core.Models.MainModels.ExpertModel;
using VPCT.Repositories.Infrastructure;
using VPCT.Repositories.IRepositories;

namespace VPCT.Repositories.Repositories.MainModels.ExpertModel
{
    public class KinhNghiemRepository(VPCTDbContext context) : BaseRepository<KinhNghiem>(context), IKinhNghiemRepository
    {
        public IQueryable<KinhNghiem> SearchKinhNghiemByChuyenGiaId(int chuyenGiaId)
        {
            return dataContext.KinhNghiem.Where(x => x.ChuyenGiaId == chuyenGiaId);
        }
    }
}
