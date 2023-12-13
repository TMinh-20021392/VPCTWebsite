using Microsoft.EntityFrameworkCore;
using VPCT.Core.DbContext;
using VPCT.Core.Models.MainModels.ProductModel;
using VPCT.Repositories.Infrastructure;
using VPCT.Repositories.IRepositories;

namespace VPCT.Repositories.Repositories.MainModels.ProductModel
{
    public class LoaiSanPhamRepository(VPCTDbContext context) : BaseRepository<LoaiSanPham>(context), ILoaiSanPhamRepository
    {
        public IQueryable<LoaiSanPham> SearchLoaiSanPhamByDangSanPhamId(int dangSanPhamId)
        {
            return dataContext.LoaiSanPham.Where(x => x.DangSanPhamId == dangSanPhamId);
        }

        public IQueryable<LoaiSanPham> SearchLoaiSanPhamByDangSanPhamName(string dangSanPham)
        {
            return dataContext.LoaiSanPham.Include(x=>x.DangSanPham).Where(x => x.DangSanPham.Name == dangSanPham);
        }
    }
}
