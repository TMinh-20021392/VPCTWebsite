using VPCT.Core.Models.MainModels.ProductModel.TaskProduct;
using VPCT.Repositories.Infrastructure;

namespace VPCT.Repositories.IRepositories.MainModels.ProductModel.TaskProduct
{
    public interface IThanhLapDoanhNghiepRepository : IBaseRepository<ThanhLapDoanhNghiep>
    {
        IQueryable<ThanhLapDoanhNghiep> SearchThanhLapDoanhNghiepByNhiemVuId(int nhiemVuId);

    }
}