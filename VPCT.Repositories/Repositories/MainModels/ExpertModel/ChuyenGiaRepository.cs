using Microsoft.EntityFrameworkCore;
using VPCT.Core.DbContext;
using VPCT.Core.Models.MainModels.ExpertModel;
using VPCT.Repositories.Infrastructure;
using VPCT.Repositories.IRepositories;

namespace VPCT.Repositories.Repositories.MainModels.ExpertModel
{
    public class ChuyenGiaRepository(VPCTDbContext context) : BaseRepository<ChuyenGia>(context), IChuyenGiaRepository
    {
        public IQueryable<ChuyenGia> SearchChuyenGia(int? categoryId = null, int? programId = null, int? periodId = null)
        {
            IQueryable<ChuyenGia> query = dataContext.ChuyenGia.Include(x=>x.ChuongTrinh);

            if (categoryId != null)
            {
                query = query.Include(x=>x.ChuongTrinh).Where(c => c.ChuongTrinh!.LoaiChuongTrinhId == categoryId);
            }

            if (programId != null)
            {
                query = query.Where(c => c.ChuongTrinhId == programId);
            }

            if (periodId != null)
            {
                query = query.Where(x => x.ChuongTrinh!.GiaiDoanId == periodId);
            }

            return query;
        }
    }
}
