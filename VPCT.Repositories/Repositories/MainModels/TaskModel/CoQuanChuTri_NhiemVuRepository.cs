using Microsoft.EntityFrameworkCore;
using VPCT.Core.DbContext;
using VPCT.Core.Models.MainModels.TaskModel;
using VPCT.Repositories.Infrastructure;
using VPCT.Repositories.IRepositories.MainModels.TaskModel;

namespace VPCT.Repositories.Repositories
{
    public class CoQuanChuTri_NhiemVuRepository(VPCTDbContext context) : BaseRepository<CoQuanChuTri_NhiemVu>(context), ICoQuanChuTri_NhiemVuRepository
    {
        public IQueryable<CoQuanChuTri_NhiemVu> SearchCoQuanChuTri_NhiemVuByNhiemVuId(int nhiemVuId)
        {
            return dataContext.CoQuanChuTri_NhiemVu.Where(x => x.NhiemVuId == nhiemVuId).Include(x=>x.DonViChuQuan).Include(x=>x.CoQuanChuTri);
        }
    }
}
