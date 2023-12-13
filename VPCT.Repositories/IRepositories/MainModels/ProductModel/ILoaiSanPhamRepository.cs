using VPCT.Core.Models.MainModels.ProductModel;
using VPCT.Repositories.Infrastructure;

namespace VPCT.Repositories.IRepositories
{
    public interface ILoaiSanPhamRepository:IBaseRepository<LoaiSanPham>
    {
        IQueryable<LoaiSanPham> SearchLoaiSanPhamByDangSanPhamId(int dangSanPhamId);
        IQueryable<LoaiSanPham> SearchLoaiSanPhamByDangSanPhamName(string dangSanPham);
    }
}