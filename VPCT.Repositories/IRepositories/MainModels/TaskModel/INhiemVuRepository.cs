using VPCT.Core.DTO;
using VPCT.Core.Models.MainModels.TaskModel;
using VPCT.Core.Models.MainModels.TaskModel.Enums;
using VPCT.Repositories.Infrastructure;

namespace VPCT.Repositories.IRepositories.MainModels.TaskModel
{
    public interface INhiemVuRepository : IBaseRepository<NhiemVu>
    {
        IQueryable<NhiemVu> TimKiemNhiemVu(List<string>? keywords = null, string? searchTerm = null, 
                int? categoryId = null, int? programId = null, int? periodId = null, KetQua? results=null, TrangThaiNhiemVu? taskStatuses = null);
        IQueryable<BaoCaoSoKet_TongHopPhanBoDTO> GetBaoCaoSoKet_TongHopPhanBoDTOs(int programId);
        public IQueryable<KetQuaNoiBatDTO> GetKetQuaNoiBatDTOs(int programId);
        public IQueryable<SanPhamThuongMaiHoaDTO> GetSanPhamThuongMaiHoaDTOs(int programId);
    }
}