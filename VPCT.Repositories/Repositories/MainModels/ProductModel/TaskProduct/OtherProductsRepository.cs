using VPCT.Core.DbContext;
using VPCT.Core.Models.MainModels.TaskModel;
using VPCT.Repositories.Infrastructure;
using VPCT.Repositories.IRepositories;

namespace VPCT.Repositories.Repositories.MainModels.ProductModel.TaskProduct
{
    public class OtherProductsRepository(VPCTDbContext context) : BaseRepository<OtherProducts>(context), IOtherProductsRepository
    {
        public IQueryable<OtherProducts> SearchOtherProductsByNhiemVuId(int nhiemVuId)
        {
            return dataContext.OtherProducts.Where(x => x.NhiemVuId == nhiemVuId);
        }
    }
}
