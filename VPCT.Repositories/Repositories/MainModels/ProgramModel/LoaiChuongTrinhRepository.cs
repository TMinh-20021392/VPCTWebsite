using VPCT.Core.DbContext;
using VPCT.Core.Models.MainModels.ProgramModel;
using VPCT.Repositories.Infrastructure;
using VPCT.Repositories.IRepositories;

namespace VPCT.Repositories.Repositories.MainModels.ProgramModel
{
    public class LoaiChuongTrinhRepository(VPCTDbContext context) : BaseRepository<LoaiChuongTrinh>(context), ILoaiChuongTrinhRepository
    {
    }
}
