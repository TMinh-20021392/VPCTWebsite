using VPCT.Core.Models.MainModels.ExpertModel;
using VPCT.Repositories.Infrastructure;

namespace VPCT.Repositories.IRepositories
{
    public interface IKinhNghiemRepository:IBaseRepository<KinhNghiem>
    {
        IQueryable<KinhNghiem> SearchKinhNghiemByChuyenGiaId(int chuyenGiaId);
    }
}