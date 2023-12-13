using VPCT.Core.Models.MainModels.ExpertModel;
using VPCT.Repositories.Infrastructure;

namespace VPCT.Repositories.IRepositories.MainModels.ExpertModel
{
    public interface IVanBangRepository : IBaseRepository<VanBang>
    {
        IQueryable<VanBang> SearchVanBangByChuyenGiaId(int chuyenGiaId);

    }
}