using VPCT.Core.Models.MainModels.DepartmentModel;

namespace VPCT.Repositories.Infrastructure
{
    public interface ICoQuanChuTriRepository:IBaseRepository<CoQuanChuTri>
    {
        IQueryable<CoQuanChuTri> SearchCoQuanChuTriByDonViChuQuanId(int donViChuQuanId);
        IQueryable<CoQuanChuTri> SearchCoQuanChuTriByDonViChuQuanName(string donViChuQuan);
    }
}