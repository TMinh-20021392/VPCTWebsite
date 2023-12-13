using VPCT.Core.DbContext;
using VPCT.Core.Models.DocAndFileTypes;
using VPCT.Repositories.Infrastructure;

namespace VPCT.Repositories.Repositories.DocAndFileTypes
{
    public class DocTypeRepository(VPCTDbContext context) : BaseRepository<DocType>(context), IDocTypeRepository
    {
    }
}
