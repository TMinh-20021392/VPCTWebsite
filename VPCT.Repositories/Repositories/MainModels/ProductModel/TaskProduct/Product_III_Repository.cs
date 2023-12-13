using VPCT.Core.DbContext;
using VPCT.Core.Models.MainModels.ProductModel.TaskProduct;
using VPCT.Repositories.Infrastructure;
using VPCT.Repositories.IRepositories;

namespace VPCT.Repositories.Repositories
{
    public class Product_III_Repository(VPCTDbContext context) : BaseRepository<Product_III>(context), IProduct_III_Repository
    {
        public IQueryable<Product_III> SearchProduct_IIIByNhiemVuId(int nhiemVuId)
        {
            return dataContext.Product_IIIs.Where(x => x.NhiemVuId == nhiemVuId);

        }
    }
}
