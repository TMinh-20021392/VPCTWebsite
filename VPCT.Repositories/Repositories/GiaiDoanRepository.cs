using VPCT.Core.DbContext;
using VPCT.Core.Models;
using VPCT.Repositories.Infrastructure;
using VPCT.Repositories.IRepositories;

namespace VPCT.Repositories.Repositories
{
    public class GiaiDoanRepository(VPCTDbContext context) : BaseRepository<GiaiDoan>(context), IGiaiDoanRepository
    {
    }
}
