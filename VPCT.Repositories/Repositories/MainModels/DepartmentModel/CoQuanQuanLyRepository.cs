using VPCT.Core.DbContext;
using VPCT.Core.Models.MainModels.DepartmentModel;
using VPCT.Repositories.Infrastructure;

namespace VPCT.Repositories.Repositories
{
    public class CoQuanQuanLyRepository(VPCTDbContext context) : BaseRepository<CoQuanQuanLy>(context), ICoQuanQuanLyRepository
    {
        public IQueryable<CoQuanQuanLy> SearchCoQuanQuanLyByLoaiQuanLy(CoQuanQuanLy.LoaiQuanLy loaiQuanLy)
        {
            return dataContext.CoQuanQuanLy.Where(x => x.Type == loaiQuanLy);
        }
    }
}
