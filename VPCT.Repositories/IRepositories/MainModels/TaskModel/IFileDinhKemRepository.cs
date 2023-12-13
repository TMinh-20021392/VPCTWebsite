using VPCT.Core.Models.MainModels.TaskModel;

namespace VPCT.Repositories.Infrastructure
{
    public interface IFileDinhKemRepository:IBaseRepository<FileDinhKem>
    {
        public IQueryable<FileDinhKem> SearchFileDinhKemByNhiemVuId(int nhiemVuId);
    }
}