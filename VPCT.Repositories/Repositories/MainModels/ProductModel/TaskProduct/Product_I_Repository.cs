using VPCT.Core.DbContext;
using VPCT.Core.Models.MainModels.ProductModel.TaskProduct;
using VPCT.Repositories.Infrastructure;
using VPCT.Repositories.IRepositories;

namespace VPCT.Repositories.Repositories
{
    public class Product_I_Repository(VPCTDbContext context) : BaseRepository<Product_I>(context), IProduct_I_Repository
    {
        public IQueryable<Product_I> SearchProduct_IByNhiemVuId(int nhiemVuId)
        {
            return dataContext.Product_Is.Where(x => x.NhiemVuId == nhiemVuId);

        }
    }
}
