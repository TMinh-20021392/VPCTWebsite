using Microsoft.EntityFrameworkCore;
using VPCT.Core.DbContext;
using VPCT.Core.Models.MainModels.TaskModel;
using VPCT.Repositories.Infrastructure;
using VPCT.Repositories.IRepositories.MainModels.TaskModel;

namespace VPCT.Repositories.Repositories.MainModels.TaskModel
{
    public class HoiDongKhoaHoc_ChuyenGiaRepository(VPCTDbContext context) : BaseRepository<HoiDongKhoaHoc_ChuyenGia>(context), IHoiDongKhoaHoc_ChuyenGiaRepository
    {
        public IQueryable<HoiDongKhoaHoc_ChuyenGia> SearchHoiDongKhoaHoc_ChuyenGiaByHoiDongKhoaHocId(int councilId)
        {
            return dataContext.HoiDongKhoaHoc_ChuyenGia.Where(x => x.HoiDongKhoaHocId == councilId).Include(x => x.ChuyenGia);
        }
    }
}
