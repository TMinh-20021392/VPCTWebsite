using VPCT.Repositories.IRepositories;
using VPCT.Repositories.IRepositories.MainModels.ExpertModel;
using VPCT.Repositories.IRepositories.MainModels.FieldModel;
using VPCT.Repositories.IRepositories.MainModels.ProductModel.TaskProduct;
using VPCT.Repositories.IRepositories.MainModels.ProgramModel;
using VPCT.Repositories.IRepositories.MainModels.TaskModel;

namespace VPCT.Repositories.Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        public IDocTypeRepository DocTypeRepository { get; }
        public IFileTypeRepository FileTypeRepository { get; }
        public IDonViChuQuanRepository DonViChuQuanRepository { get; }
        public ICoQuanChuTriRepository CoQuanChuTriRepository { get; }
        public ICoQuanQuanLyRepository CoQuanQuanLyRepository { get; }
        public IChuyenGiaRepository ChuyenGiaRepository { get; }
        public IHocViRepository HocViRepository { get; }
        public IHocHamRepository HocHamRepository { get; }
        public IGiaiThuongRepository GiaiThuongRepository { get; }
        public IVanBangRepository VanBangRepository { get; }
        public IKinhNghiemRepository KinhNghiemRepository { get; }
        public IHoatDongKhacRepository HoatDongKhacRepository { get; }
        public IChucVuRepository ChucVuRepository { get; }
        public ICongTrinhRepository CongTrinhRepository { get; }
        public IAnPhamRepository AnPhamRepository { get; }
        public IChucDanhRepository ChucDanhRepository { get; }
        public ILinhVucRepository LinhVucRepository { get; }
        public IChuyenNganhRepository ChuyenNganhRepository { get; }
        public IDangSanPhamRepository DangSanPhamRepository { get; }
        public ILoaiSanPhamRepository LoaiSanPhamRepository { get; }
        public IChuongTrinhRepository ChuongTrinhRepository { get; }
        public ILoaiChuongTrinhRepository LoaiChuongTrinhRepository { get; }
        public IFileDinhKemRepository FileDinhKemRepository { get; }
        public IPhanBoNoiDungRepository PhanBoNoiDungRepository { get; }
        public ICongVanNhiemVuRepository CongVanNhiemVuRepository { get; }
        public IHoiDongKhoaHoc_ChuyenGiaRepository HoiDongKhoaHoc_ChuyenGiaRepository { get; }
        public ILanDieuChinhRepository LanDieuChinhRepository { get; }
        public ICaNhanThamGiaRepository CaNhanThamGiaRepository { get; }
        public IHoiDongKhoaHocRepository HoiDongKhoaHocRepository { get; }
        public INhiemVuRepository NhiemVuRepository { get; }
        public IDonViChuQuan_NhiemVuRepository DonViChuQuan_NhiemVuRepository { get; }
        public ICoQuanChuTri_NhiemVuRepository CoQuanChuTri_NhiemVuRepository { get; }
        public ILanKiemTraRepository LanKiemTraRepository { get; }
        public IGiaiDoanRepository GiaiDoanRepository { get; }
        public IThanhLapDoanhNghiepRepository ThanhLapDoanhNghiepRepository { get; }
        public IOtherProductsRepository OtherProductsRepository { get; }
        public IOwnershipRepository OwnershipRepository { get; }
        public IProduct_I_Repository Product_I_Repository { get; }
        public IProduct_II_Repository Product_II_Repository { get; }
        public IProduct_III_Repository Product_III_Repository { get; }
        public IProduct_PostgraduateTraining_Repository Product_PostgraduateTraining_Repository { get; }
        public IChuongTrinh_CoQuanQuanLyRepository ChuongTrinh_CoQuanQuanLyRepository {  get; }
        int SaveChanges();
    }
}
