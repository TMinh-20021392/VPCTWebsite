using VPCT.Core.Models.MainModels.ProductModel.TaskProduct;
using VPCT.Repositories.Infrastructure;

namespace VPCT.Repositories.IRepositories
{
    public interface IOwnershipRepository:IBaseRepository<Ownership>
    {
        IQueryable<Ownership> SearchOwnershipByNhiemVuId(int nhiemVuId);
    }
}