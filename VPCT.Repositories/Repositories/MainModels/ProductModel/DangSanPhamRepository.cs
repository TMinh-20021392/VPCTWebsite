using VPCT.Core.DbContext;
using VPCT.Core.Models.MainModels.ProductModel;
using VPCT.Repositories.Infrastructure;
using VPCT.Repositories.IRepositories;

namespace VPCT.Repositories.Repositories.MainModels.ProductModel
{
    public class DangSanPhamRepository(VPCTDbContext context) : BaseRepository<DangSanPham>(context), IDangSanPhamRepository
    {
    }
}
