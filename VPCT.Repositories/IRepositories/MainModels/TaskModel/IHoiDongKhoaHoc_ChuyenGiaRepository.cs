using VPCT.Core.Models.MainModels.TaskModel;
using VPCT.Repositories.Infrastructure;

namespace VPCT.Repositories.IRepositories.MainModels.TaskModel
{
    public interface IHoiDongKhoaHoc_ChuyenGiaRepository : IBaseRepository<HoiDongKhoaHoc_ChuyenGia>
    {
        public IQueryable<HoiDongKhoaHoc_ChuyenGia> SearchHoiDongKhoaHoc_ChuyenGiaByHoiDongKhoaHocId(int councilId);

    }
}