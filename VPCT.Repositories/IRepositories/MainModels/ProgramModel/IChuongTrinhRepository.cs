using VPCT.Core.DTO;
using VPCT.Core.Models.MainModels.ProgramModel;
using VPCT.Repositories.Infrastructure;

namespace VPCT.Repositories.IRepositories
{
    public interface IChuongTrinhRepository : IBaseRepository<ChuongTrinh>
    {
        IQueryable<ChuongTrinh> GetChuongTrinhsByCategory(int? categoryId, int? periodId);
        IQueryable<ChuongTrinh_SanPhamDTO> GetProduct_ICountByCategory(int categoryId);
        IQueryable<ChuongTrinh_SanPhamDTO> GetProduct_IICountByCategory(int categoryId);
        IQueryable<ChuongTrinh_SanPhamDTO> GetProduct_IIICountByCategory(int categoryId);
        IQueryable<ChuongTrinh_SanPhamDTO> GetProduct_PostgraduateTrainingsCountByCategory(int categoryId);
        IQueryable<ChuongTrinh_OtherProductsDTO> GetOtherProductsCountByCategory(int categoryId);
        IQueryable<ChuongTrinh_SanPhamDTO> GetOwnershipCountByCategory(int categoryId);

        IQueryable<ChuongTrinh_TinhHinhThucHienDTO> GetChuongTrinh_TinhHinhThucHienDTOs(int categoryId);
        IQueryable<NhiemVu_DungThucHienDTO> GetNhiemVu_DungThucHienDTOs(int categoryId);
        IQueryable<ThongKeChuongTrinhDTO> GetThongKeChuongTrinhDTOs(int categoryId);
    }
}