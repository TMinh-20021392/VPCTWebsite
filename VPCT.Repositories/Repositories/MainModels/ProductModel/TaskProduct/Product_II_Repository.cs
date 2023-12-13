using VPCT.Core.DbContext;
using VPCT.Core.Models.MainModels.ProductModel.TaskProduct;
using VPCT.Repositories.Infrastructure;

namespace VPCT.Repositories.Repositories
{
    public class Product_II_Repository(VPCTDbContext context) : BaseRepository<Product_II>(context), IProduct_II_Repository
    {
        public IQueryable<Product_II> SearchProduct_IIByNhiemVuId(int nhiemVuId)
        {
            return dataContext.Product_IIs.Where(x => x.NhiemVuId == nhiemVuId);
        }
    }
}
