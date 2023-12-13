using VPCT.Core.DbContext;
using VPCT.Core.Models.MainModels.FieldModel;
using VPCT.Repositories.Infrastructure;
using VPCT.Repositories.IRepositories.MainModels.FieldModel;

namespace VPCT.Repositories.Repositories
{
    public class LinhVucRepository(VPCTDbContext context) : BaseRepository<LinhVuc>(context), ILinhVucRepository
    {
    }
}
