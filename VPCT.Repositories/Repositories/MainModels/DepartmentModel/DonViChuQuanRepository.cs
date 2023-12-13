using VPCT.Core.DbContext;
using VPCT.Core.Models.MainModels.DepartmentModel;
using VPCT.Repositories.Infrastructure;

namespace VPCT.Repositories.Repositories
{
    public class DonViChuQuanRepository(VPCTDbContext context) : BaseRepository<DonViChuQuan>(context), IDonViChuQuanRepository
    {
    }
}
