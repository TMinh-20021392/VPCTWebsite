using VPCT.Core.DbContext;
using VPCT.Core.Models.MainModels.ExpertModel;
using VPCT.Repositories.Infrastructure;
using VPCT.Repositories.IRepositories;

namespace VPCT.Repositories.Repositories
{
    public class ChucDanhRepository(VPCTDbContext context) : BaseRepository<ChucDanh>(context), IChucDanhRepository
    {
    }
}
