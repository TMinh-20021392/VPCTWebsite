using Microsoft.EntityFrameworkCore;
using VPCT.Core.DbContext;
using VPCT.Core.Models.MainModels.DepartmentModel;
using VPCT.Repositories.Infrastructure;

namespace VPCT.Repositories.Repositories
{
    public class CoQuanChuTriRepository(VPCTDbContext context) : BaseRepository<CoQuanChuTri>(context), ICoQuanChuTriRepository
    {
        public IQueryable<CoQuanChuTri> SearchCoQuanChuTriByDonViChuQuanId(int donViChuQuanId)
        {
            return dataContext.CoQuanChuTri.Where(x=>x.DonViChuQuanId == donViChuQuanId);
        }

        public IQueryable<CoQuanChuTri> SearchCoQuanChuTriByDonViChuQuanName(string donViChuQuan)
        {
            return dataContext.CoQuanChuTri.Include(x => x.DonViChuQuan).Where(x => x.DonViChuQuan.Name == donViChuQuan);
        }
    }
}
