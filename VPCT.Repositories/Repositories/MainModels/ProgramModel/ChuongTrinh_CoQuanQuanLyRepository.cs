using Microsoft.EntityFrameworkCore;
using VPCT.Core.DbContext;
using VPCT.Core.Models.MainModels.DepartmentModel;
using VPCT.Core.Models.MainModels.ProgramModel;
using VPCT.Repositories.Infrastructure;
using VPCT.Repositories.IRepositories.MainModels.ProgramModel;

namespace VPCT.Repositories.Repositories.MainModels.ProgramModel
{
    public class ChuongTrinh_CoQuanQuanLyRepository(VPCTDbContext context) : BaseRepository<ChuongTrinh_CoQuanQuanLy>(context), IChuongTrinh_CoQuanQuanLyRepository
    {
        public IQueryable<CoQuanQuanLy?> SearchCoQuanQuanLyByChuongTrinh(int ctId)
        {
            return dataContext.ChuongTrinh_CoQuanQuanLys.Where(x => x.ChuongTrinhId == ctId).Include(x=>x.CoQuanQuanLy).Select(x => x.CoQuanQuanLy);
        }
    }
}
