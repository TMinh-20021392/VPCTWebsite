using VPCT.Core.DbContext;
using VPCT.Core.Models.MainModels.ProductModel.TaskProduct;
using VPCT.Repositories.Infrastructure;
using VPCT.Repositories.IRepositories;

namespace VPCT.Repositories.Repositories.MainModels.ProductModel.TaskProduct
{
    public class OwnershipRepository(VPCTDbContext context) : BaseRepository<Ownership>(context), IOwnershipRepository
    {
        public IQueryable<Ownership> SearchOwnershipByNhiemVuId(int nhiemVuId)
        {
            return dataContext.Ownerships.Where(x => x.NhiemVuId == nhiemVuId);

        }
    }
}
