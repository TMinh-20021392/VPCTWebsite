using VPCT.Core.DbContext;
using VPCT.Core.Models.MainModels.ExpertModel;
using VPCT.Repositories.Infrastructure;
using VPCT.Repositories.IRepositories;

namespace VPCT.Repositories.Repositories.MainModels.ExpertModel
{
    public class ChucVuRepository(VPCTDbContext context) : BaseRepository<ChucVu>(context), IChucVuRepository
    {
    }
}
