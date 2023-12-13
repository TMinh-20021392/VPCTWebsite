using VPCT.Core.DbContext;
using VPCT.Core.Models.MainModels.ExpertModel;
using VPCT.Repositories.Infrastructure;
using VPCT.Repositories.IRepositories;

namespace VPCT.Repositories.Repositories.MainModels.ExpertModel
{
    public class HoatDongKhacRepository(VPCTDbContext context) : BaseRepository<HoatDongKhac>(context), IHoatDongKhacRepository
    {
        public IQueryable<HoatDongKhac> SearchHoatDongKhacByChuyenGiaId(int chuyenGiaId)
        {
            return dataContext.HoatDongKhac.Where(x => x.ChuyenGiaId == chuyenGiaId);
        }
    }
}
