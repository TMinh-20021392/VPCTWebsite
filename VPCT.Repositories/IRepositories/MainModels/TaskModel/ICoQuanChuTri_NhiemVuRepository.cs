using VPCT.Core.Models.MainModels.TaskModel;
using VPCT.Repositories.Infrastructure;

namespace VPCT.Repositories.IRepositories.MainModels.TaskModel
{
    public interface ICoQuanChuTri_NhiemVuRepository : IBaseRepository<CoQuanChuTri_NhiemVu>
    {
        public IQueryable<CoQuanChuTri_NhiemVu> SearchCoQuanChuTri_NhiemVuByNhiemVuId(int nhiemVuId);
    }
}