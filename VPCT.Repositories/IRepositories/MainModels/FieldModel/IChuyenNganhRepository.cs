using VPCT.Core.Models.MainModels.FieldModel;
using VPCT.Repositories.Infrastructure;

namespace VPCT.Repositories.IRepositories
{
    public interface IChuyenNganhRepository:IBaseRepository<ChuyenNganh>
    {
        IQueryable<ChuyenNganh> SearchChuyenNganhByLinhVucId(int linhVucId);

    }
}