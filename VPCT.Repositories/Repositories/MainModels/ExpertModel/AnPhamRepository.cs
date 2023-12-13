using VPCT.Core.DbContext;
using VPCT.Core.Models.MainModels.ExpertModel;
using VPCT.Repositories.Infrastructure;
using VPCT.Repositories.IRepositories;

namespace VPCT.Repositories.Repositories
{
    public class AnPhamRepository(VPCTDbContext context) : BaseRepository<AnPham>(context), IAnPhamRepository
    {
        public IQueryable<AnPham> SearchAnPhamByChuyenGiaId(int chuyenGiaId)
        {
            return dataContext.AnPham.Where(x => x.ChuyenGiaId == chuyenGiaId);
        }
    }
}
