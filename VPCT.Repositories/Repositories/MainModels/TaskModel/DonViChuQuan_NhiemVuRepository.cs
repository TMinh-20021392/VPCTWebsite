using Microsoft.EntityFrameworkCore;
using VPCT.Core.DbContext;
using VPCT.Core.Models.MainModels.TaskModel;
using VPCT.Repositories.Infrastructure;
using VPCT.Repositories.IRepositories;

namespace VPCT.Repositories.Repositories
{
    public class DonViChuQuan_NhiemVuRepository(VPCTDbContext context) : BaseRepository<DonViChuQuan_NhiemVu>(context), IDonViChuQuan_NhiemVuRepository
    {
        public IQueryable<DonViChuQuan_NhiemVu> SearchDonViChuQuan_NhiemVuByNhiemVuId(int nhiemVuId)
        {
            return dataContext.DonViChuQuan_NhiemVu.Where(x => x.NhiemVuId == nhiemVuId).Include(x=>x.DonViChuQuan);
        }
    }
}
