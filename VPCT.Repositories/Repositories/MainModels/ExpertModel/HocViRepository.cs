using VPCT.Core.DbContext;
using VPCT.Core.Models.MainModels.ExpertModel;
using VPCT.Repositories.Infrastructure;
using VPCT.Repositories.IRepositories.MainModels.ExpertModel;

namespace VPCT.Repositories.Repositories
{
    public class HocViRepository(VPCTDbContext context) : BaseRepository<HocVi>(context), IHocViRepository
    {
    }
}
