using VPCT.Core.DbContext;
using VPCT.Core.Models.MainModels.TaskModel;
using VPCT.Repositories.Infrastructure;
using VPCT.Repositories.IRepositories.MainModels.TaskModel;

namespace VPCT.Repositories.Repositories
{
    public class HoiDongKhoaHocRepository(VPCTDbContext context) : BaseRepository<HoiDongKhoaHoc>(context), IHoiDongKhoaHocRepository
    {
        public IQueryable<HoiDongKhoaHoc> SearchHoiDongKhoaHocByNhiemVuId(int nhiemVuId)
        {
            return dataContext.HoiDongKhoaHoc.Where(x => x.NhiemVuId == nhiemVuId);
        }
    }
}
