using VPCT.Core.DbContext;
using VPCT.Core.Models.DocAndFileTypes;
using VPCT.Repositories.Infrastructure;

namespace VPCT.Repositories.Repositories.DocAndFileTypes
{
    public class FileTypeRepository(VPCTDbContext context) : BaseRepository<FileType>(context), IFileTypeRepository
    {
    }
}
