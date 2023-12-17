using VPCT.Core.DTO;
using VPCT.Core.Models.MainModels.ProgramModel;
using VPCT.Repositories.Infrastructure;

namespace VPCT.Repositories.IRepositories
{
    public interface IChuongTrinhRepository : IBaseRepository<ChuongTrinh>
    {
        IQueryable<ChuongTrinh> GetChuongTrinhsByCategory(int? categoryId, int? periodId);
        IEnumerable<ChuongTrinhProductCounts> GetProduct_ICountByCategory(int categoryId);
        IEnumerable<ChuongTrinhProductCounts> GetProduct_IICountByCategory(int categoryId);
        IEnumerable<ChuongTrinhProductCounts> GetProduct_IIICountByCategory(int categoryId);
        IEnumerable<ChuongTrinhProductCounts> GetProduct_PostgraduateTrainingsCountByCategory(int categoryId);
        IEnumerable<Other_CountDTO> GetOtherProductsCountByCategory(int categoryId);
        IEnumerable<ChuongTrinhProductCounts> GetOwnershipCountByCategory(int categoryId);

        IQueryable<ChuongTrinh_TinhHinhThucHienDTO> GetChuongTrinh_TinhHinhThucHienDTOs(int categoryId);
        IQueryable<NhiemVu_DungThucHienDTO> GetNhiemVu_DungThucHienDTOs(int categoryId);
        IQueryable<ThongKeChuongTrinhDTO> GetThongKeChuongTrinhDTOs(int categoryId);
    }
}