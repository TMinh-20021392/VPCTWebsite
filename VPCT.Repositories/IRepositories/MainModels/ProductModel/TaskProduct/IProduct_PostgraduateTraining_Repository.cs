using VPCT.Core.Models.MainModels.ProductModel.TaskProduct;
using VPCT.Repositories.Infrastructure;

namespace VPCT.Repositories.IRepositories
{
    public interface IProduct_PostgraduateTraining_Repository:IBaseRepository<Product_PostgraduateTraining>
    {
        IQueryable<Product_PostgraduateTraining> SearchProduct_PostgraduateTrainingByNhiemVuId(int nhiemVuId);

    }
}