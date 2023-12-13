using VPCT.Core.Models.MainModels.ProductModel.TaskProduct;
using VPCT.Repositories.Infrastructure;

namespace VPCT.Repositories.IRepositories
{
    public interface IProduct_III_Repository:IBaseRepository<Product_III>
    {
        IQueryable<Product_III> SearchProduct_IIIByNhiemVuId(int nhiemVuId);

    }
}