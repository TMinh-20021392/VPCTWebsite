using VPCT.Core.Models.MainModels.ExpertModel;
using VPCT.Repositories.Infrastructure;

namespace VPCT.Repositories.IRepositories
{
    public interface IHoatDongKhacRepository:IBaseRepository<HoatDongKhac>
    {
        IQueryable<HoatDongKhac> SearchHoatDongKhacByChuyenGiaId(int chuyenGiaId);

    }
}