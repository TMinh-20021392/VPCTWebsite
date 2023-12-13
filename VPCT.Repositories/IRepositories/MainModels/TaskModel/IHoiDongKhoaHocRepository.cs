using VPCT.Core.Models.MainModels.TaskModel;
using VPCT.Repositories.Infrastructure;

namespace VPCT.Repositories.IRepositories.MainModels.TaskModel
{
    public interface IHoiDongKhoaHocRepository : IBaseRepository<HoiDongKhoaHoc>
    {
        public IQueryable<HoiDongKhoaHoc> SearchHoiDongKhoaHocByNhiemVuId(int nhiemVuId);
    }
}