using VPCT.Core.Models.MainModels.TaskModel;
using VPCT.Repositories.Infrastructure;

namespace VPCT.Repositories.IRepositories
{
    public interface IOtherProductsRepository:IBaseRepository<OtherProducts>
    {
        IQueryable<OtherProducts> SearchOtherProductsByNhiemVuId(int nhiemVuId);
    }
}