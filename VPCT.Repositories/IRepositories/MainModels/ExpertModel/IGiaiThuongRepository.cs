using VPCT.Core.Models.MainModels.ExpertModel;
using VPCT.Repositories.Infrastructure;

namespace VPCT.Repositories.IRepositories.MainModels.ExpertModel
{
    public interface IGiaiThuongRepository : IBaseRepository<GiaiThuong>
    {
        IQueryable<GiaiThuong> SearchGiaiThuongByChuyenGiaId(int chuyenGiaId);

    }
}