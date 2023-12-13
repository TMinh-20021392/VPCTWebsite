using VPCT.Core.DbContext;
using VPCT.Core.Models.MainModels.ProductModel.TaskProduct;
using VPCT.Repositories.Infrastructure;
using VPCT.Repositories.IRepositories.MainModels.ProductModel.TaskProduct;

namespace VPCT.Repositories.Repositories
{
    public class ThanhLapDoanhNghiepRepository(VPCTDbContext context) : BaseRepository<ThanhLapDoanhNghiep>(context), IThanhLapDoanhNghiepRepository
    {
        public IQueryable<ThanhLapDoanhNghiep> SearchThanhLapDoanhNghiepByNhiemVuId(int nhiemVuId)
        {
            return dataContext.ThanhLapDoanhNghiep.Where(x => x.NhiemVuId == nhiemVuId);
        }
    }
}
