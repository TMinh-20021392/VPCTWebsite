using VPCT.Core.Models.MainModels.ProductModel.TaskProduct;

namespace VPCT.Repositories.Infrastructure
{
    public interface IProduct_II_Repository:IBaseRepository<Product_II>
    {
        IQueryable<Product_II> SearchProduct_IIByNhiemVuId(int nhiemVuId);

    }
}