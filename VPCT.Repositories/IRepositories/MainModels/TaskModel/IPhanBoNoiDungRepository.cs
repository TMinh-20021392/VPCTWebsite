using VPCT.Core.Models.MainModels.TaskModel;

namespace VPCT.Repositories.Infrastructure
{
    public interface IPhanBoNoiDungRepository:IBaseRepository<PhanBoNoiDung>
    {
        public IQueryable<PhanBoNoiDung> SearchPhanBoNoiDungByNhiemVuId(int nhiemVuId);
    }
}