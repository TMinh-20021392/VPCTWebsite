using VPCT.Core.Models.MainModels.ExpertModel;
using VPCT.Repositories.Infrastructure;

namespace VPCT.Repositories.IRepositories
{
    public interface IAnPhamRepository:IBaseRepository<AnPham>
    {
        IQueryable<AnPham> SearchAnPhamByChuyenGiaId(int chuyenGiaId);
    }
}