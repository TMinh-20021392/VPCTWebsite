using VPCT.Core.Models.MainModels.ExpertModel;
using VPCT.Repositories.Infrastructure;

namespace VPCT.Repositories.IRepositories
{
    public interface IChuyenGiaRepository:IBaseRepository<ChuyenGia>
    {
        IQueryable<ChuyenGia> SearchChuyenGia(int? categoryId = null, int? programId = null, int? periodId = null);

    }
}