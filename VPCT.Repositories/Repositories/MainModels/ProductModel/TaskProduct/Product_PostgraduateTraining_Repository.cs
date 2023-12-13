using VPCT.Core.DbContext;
using VPCT.Core.Models.MainModels.ProductModel.TaskProduct;
using VPCT.Repositories.Infrastructure;
using VPCT.Repositories.IRepositories;

namespace VPCT.Repositories.Repositories
{
    public class Product_PostgraduateTraining_Repository(VPCTDbContext context) : BaseRepository<Product_PostgraduateTraining>(context), IProduct_PostgraduateTraining_Repository
    {
        public IQueryable<Product_PostgraduateTraining> SearchProduct_PostgraduateTrainingByNhiemVuId(int nhiemVuId)
        {
            return dataContext.Product_PostgraduateTraining.Where(x => x.NhiemVuId == nhiemVuId);

        }
    }
}
