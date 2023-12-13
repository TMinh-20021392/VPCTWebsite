using VPCT.Core.DbContext;
using VPCT.Repositories.IRepositories;
using VPCT.Repositories.IRepositories.MainModels.ExpertModel;
using VPCT.Repositories.IRepositories.MainModels.FieldModel;
using VPCT.Repositories.IRepositories.MainModels.ProductModel.TaskProduct;
using VPCT.Repositories.IRepositories.MainModels.ProgramModel;
using VPCT.Repositories.IRepositories.MainModels.TaskModel;
using VPCT.Repositories.Repositories;
using VPCT.Repositories.Repositories.DocAndFileTypes;
using VPCT.Repositories.Repositories.MainModels.ExpertModel;
using VPCT.Repositories.Repositories.MainModels.ProductModel;
using VPCT.Repositories.Repositories.MainModels.ProductModel.TaskProduct;
using VPCT.Repositories.Repositories.MainModels.ProgramModel;
using VPCT.Repositories.Repositories.MainModels.TaskModel;

namespace VPCT.Repositories.Infrastructure
{
    public class UnitOfWork(VPCTDbContext? context = null) : IUnitOfWork
    {
        private readonly VPCTDbContext _context = context ?? new VPCTDbContext();
        private readonly IDocTypeRepository? _docTypeRepository;
        private readonly IFileTypeRepository? _fileTypeRepository;
        private readonly IDonViChuQuanRepository? donViChuQuanRepository;
        private readonly ICoQuanChuTriRepository? coQuanChuTriRepository;
        private readonly ICoQuanQuanLyRepository? coQuanQuanLyRepository;
        private readonly IChuyenGiaRepository? chuyenGiaRepository;
        private readonly IHocViRepository? hocViRepository;
        private readonly IHocHamRepository? hocHamRepository;
        private readonly IGiaiThuongRepository? giaiThuongRepository;
        private readonly IVanBangRepository? vanBangRepository;
        private readonly IKinhNghiemRepository? kinhNghiemRepository;
        private readonly IHoatDongKhacRepository? hoatDongKhacRepository;
        private readonly IChucVuRepository? chucVuRepository;
        private readonly ICongTrinhRepository? congTrinhRepository;
        private readonly IAnPhamRepository? anPhamRepository;
        private readonly IChucDanhRepository? chucDanhRepository;
        private readonly ILinhVucRepository? linhVucRepository;
        private readonly IChuyenNganhRepository? chuyenNganhRepository;
        private readonly IDangSanPhamRepository? dangSanPhamRepository;
        private readonly ILoaiSanPhamRepository? loaiSanPhamRepository;
        private readonly IChuongTrinhRepository? chuongTrinhRepository;
        private readonly ILoaiChuongTrinhRepository? loaiChuongTrinhRepository;
        private readonly IFileDinhKemRepository? fileDinhKemRepository;
        private readonly IPhanBoNoiDungRepository? phanBoNoiDungRepository;
        private readonly ICongVanNhiemVuRepository? congVanNhiemVuRepository;
        private readonly IHoiDongKhoaHoc_ChuyenGiaRepository? hoiDongKhoaHoc_ChuyenGiaRepository;
        private readonly ILanDieuChinhRepository? lanDieuChinhRepository;
        private readonly ICaNhanThamGiaRepository? caNhanThamGiaRepository;
        private readonly IHoiDongKhoaHocRepository? hoiDongKhoaHocRepository;
        private readonly INhiemVuRepository? nhiemVuRepository;
        private readonly IDonViChuQuan_NhiemVuRepository? donViChuQuan_NhiemVuRepository;
        private readonly ICoQuanChuTri_NhiemVuRepository? coQuanChuTri_NhiemVuRepository;
        private readonly ILanKiemTraRepository? lanKiemTraRepository;
        private readonly IGiaiDoanRepository? giaiDoanRepository;
        private readonly IThanhLapDoanhNghiepRepository? thanhLapDoanhNghiepRepository;
        private readonly IOtherProductsRepository? otherProductsRepository;
        private readonly IOwnershipRepository? ownershipRepository;
        private readonly IProduct_I_Repository? product_I_Repository;
        private readonly IProduct_II_Repository? product_II_Repository;
        private readonly IProduct_III_Repository? product_III_Repository;
        private readonly IProduct_PostgraduateTraining_Repository? product_PostgraduateTraining_Repository;
        private readonly IChuongTrinh_CoQuanQuanLyRepository? chuongTrinh_CoQuanQuanLy;

        public IDocTypeRepository DocTypeRepository => _docTypeRepository ?? new DocTypeRepository(_context);

        public IFileTypeRepository FileTypeRepository => _fileTypeRepository ?? new FileTypeRepository(_context);

        public IDonViChuQuanRepository DonViChuQuanRepository => donViChuQuanRepository ?? new DonViChuQuanRepository(_context);

        public ICoQuanChuTriRepository CoQuanChuTriRepository => coQuanChuTriRepository ?? new CoQuanChuTriRepository(_context);

        public ICoQuanQuanLyRepository CoQuanQuanLyRepository => coQuanQuanLyRepository ?? new CoQuanQuanLyRepository(_context);

        public IChuyenGiaRepository ChuyenGiaRepository => chuyenGiaRepository ?? new ChuyenGiaRepository(_context);

        public IHocViRepository HocViRepository => hocViRepository ?? new HocViRepository(_context);

        public IHocHamRepository HocHamRepository => hocHamRepository ?? new HocHamRepository(_context);

        public IGiaiThuongRepository GiaiThuongRepository => giaiThuongRepository ?? new GiaiThuongRepository(_context);

        public IVanBangRepository VanBangRepository => vanBangRepository ?? new VanBangRepository(_context);

        public IKinhNghiemRepository KinhNghiemRepository => kinhNghiemRepository ?? new KinhNghiemRepository(_context);

        public IHoatDongKhacRepository HoatDongKhacRepository => hoatDongKhacRepository ?? new HoatDongKhacRepository(_context);

        public IChucVuRepository ChucVuRepository => chucVuRepository ?? new ChucVuRepository(_context);

        public ICongTrinhRepository CongTrinhRepository => congTrinhRepository ?? new CongTrinhRepository(_context);

        public IAnPhamRepository AnPhamRepository => anPhamRepository ?? new AnPhamRepository(_context);

        public IChucDanhRepository ChucDanhRepository => chucDanhRepository ?? new ChucDanhRepository(_context);

        public ILinhVucRepository LinhVucRepository => linhVucRepository ?? new LinhVucRepository(_context);

        public IChuyenNganhRepository ChuyenNganhRepository => chuyenNganhRepository ?? new ChuyenNganhRepository(_context);

        public IDangSanPhamRepository DangSanPhamRepository => dangSanPhamRepository ?? new DangSanPhamRepository(_context);

        public ILoaiSanPhamRepository LoaiSanPhamRepository => loaiSanPhamRepository ?? new LoaiSanPhamRepository(_context);

        public IChuongTrinhRepository ChuongTrinhRepository => chuongTrinhRepository ?? new ChuongTrinhRepository(_context);

        public ILoaiChuongTrinhRepository LoaiChuongTrinhRepository => loaiChuongTrinhRepository ?? new LoaiChuongTrinhRepository(_context);

        public IFileDinhKemRepository FileDinhKemRepository => fileDinhKemRepository ?? new FileDinhKemRepository(_context);

        public IPhanBoNoiDungRepository PhanBoNoiDungRepository => phanBoNoiDungRepository ?? new PhanBoNoiDungRepository(_context);

        public ICongVanNhiemVuRepository CongVanNhiemVuRepository => congVanNhiemVuRepository ?? new CongVanNhiemVuRepository(_context);

        public IHoiDongKhoaHoc_ChuyenGiaRepository HoiDongKhoaHoc_ChuyenGiaRepository => hoiDongKhoaHoc_ChuyenGiaRepository ?? new HoiDongKhoaHoc_ChuyenGiaRepository(_context);

        public ILanDieuChinhRepository LanDieuChinhRepository => lanDieuChinhRepository ?? new LanDieuChinhRepository(_context);

        public ICaNhanThamGiaRepository CaNhanThamGiaRepository => caNhanThamGiaRepository ?? new CaNhanThamGiaRepository(_context);

        public IHoiDongKhoaHocRepository HoiDongKhoaHocRepository => hoiDongKhoaHocRepository ?? new HoiDongKhoaHocRepository(_context);

        public INhiemVuRepository NhiemVuRepository => nhiemVuRepository ?? new NhiemVuRepository(_context);

        public IDonViChuQuan_NhiemVuRepository DonViChuQuan_NhiemVuRepository => donViChuQuan_NhiemVuRepository ?? new DonViChuQuan_NhiemVuRepository(_context);

        public ICoQuanChuTri_NhiemVuRepository CoQuanChuTri_NhiemVuRepository => coQuanChuTri_NhiemVuRepository ?? new CoQuanChuTri_NhiemVuRepository(_context);

        public ILanKiemTraRepository LanKiemTraRepository => lanKiemTraRepository ?? new LanKiemTraRepository(_context);

        public IGiaiDoanRepository GiaiDoanRepository => giaiDoanRepository ?? new GiaiDoanRepository(_context);

        public IThanhLapDoanhNghiepRepository ThanhLapDoanhNghiepRepository => thanhLapDoanhNghiepRepository ?? new ThanhLapDoanhNghiepRepository(_context);

        public IOtherProductsRepository OtherProductsRepository => otherProductsRepository ?? new OtherProductsRepository(_context);

        public IOwnershipRepository OwnershipRepository => ownershipRepository ?? new OwnershipRepository(_context);

        public IProduct_PostgraduateTraining_Repository Product_PostgraduateTraining_Repository => product_PostgraduateTraining_Repository ?? new Product_PostgraduateTraining_Repository(_context);

        public IProduct_II_Repository Product_II_Repository => product_II_Repository ?? new Product_II_Repository(_context);

        public IProduct_III_Repository Product_III_Repository => product_III_Repository ?? new Product_III_Repository(_context);

        public IProduct_I_Repository Product_I_Repository => product_I_Repository ?? new Product_I_Repository(_context);
        public IChuongTrinh_CoQuanQuanLyRepository ChuongTrinh_CoQuanQuanLyRepository => chuongTrinh_CoQuanQuanLy ?? new ChuongTrinh_CoQuanQuanLyRepository(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposing)
            {
                return;
            }
            _context?.Dispose();
        }
        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
