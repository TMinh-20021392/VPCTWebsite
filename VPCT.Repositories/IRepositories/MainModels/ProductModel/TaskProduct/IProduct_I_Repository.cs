using VPCT.Core.Models.MainModels.ProductModel.TaskProduct;
using VPCT.Repositories.Infrastructure;

namespace VPCT.Repositories.IRepositories
{
    public interface IProduct_I_Repository:IBaseRepository<Product_I>
    {
        IQueryable<Product_I> SearchProduct_IByNhiemVuId(int nhiemVuId);

    }
}