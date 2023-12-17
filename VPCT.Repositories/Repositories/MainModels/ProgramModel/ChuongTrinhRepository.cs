using Microsoft.EntityFrameworkCore;
using VPCT.Core.DbContext;
using VPCT.Core.DTO;
using VPCT.Core.Models.MainModels.ProgramModel;
using VPCT.Core.Models.MainModels.TaskModel.Enums;
using VPCT.Repositories.Infrastructure;
using VPCT.Repositories.IRepositories;

namespace VPCT.Repositories.Repositories.MainModels.ProgramModel
{
    public class ChuongTrinhRepository(VPCTDbContext context) : BaseRepository<ChuongTrinh>(context), IChuongTrinhRepository
    {
        public IEnumerable<ChuongTrinhProductCounts> GetProduct_ICountByCategory(int categoryId)
        {
            var distinctLoaiSanPhamNames = dataContext.LoaiSanPham.Where(x => x.DangSanPhamId == 1).Select(l => l.Name).ToList();

            var chuongTrinhProductCounts = dataContext.ChuongTrinh.Where(x => x.LoaiChuongTrinhId == categoryId)
                .Include(x => x.NhiemVu)!
                .ThenInclude(x => x.Product_Is).ThenInclude(x=>x.LoaiSanPham)
                .AsEnumerable()
                .Select(chuongTrinh => new ChuongTrinhProductCounts
                {
                    MaChuongTrinh = chuongTrinh.MaChuongTrinh,
                    LoaiSanPhamCounts = distinctLoaiSanPhamNames
                        .Select(name => new CountOfProduct
                        {
                            LoaiSp = name,
                            Count = chuongTrinh.NhiemVu
                                .SelectMany(nhiemVu => nhiemVu.Product_Is)
                                .Count(product => product.LoaiSanPham.Name == name)
                        })
                        .ToList()
                });

            return chuongTrinhProductCounts;
        }
        public IEnumerable<ChuongTrinhProductCounts> GetProduct_IICountByCategory(int categoryId)
        {
            var distinctLoaiSanPhamNames = dataContext.LoaiSanPham.Where(x => x.DangSanPhamId == 2).Select(l => l.Name).ToList();

            var chuongTrinhProductCounts = dataContext.ChuongTrinh.Where(x => x.LoaiChuongTrinhId == categoryId)
                                .Include(x => x.NhiemVu)!
                .ThenInclude(x => x.Product_IIs).ThenInclude(x => x.LoaiSanPham)
                .AsEnumerable()
                .Select(chuongTrinh => new ChuongTrinhProductCounts
                {
                    MaChuongTrinh = chuongTrinh.MaChuongTrinh,
                    LoaiSanPhamCounts = distinctLoaiSanPhamNames
                        .Select(name => new CountOfProduct
                        {
                            LoaiSp = name,
                            Count = chuongTrinh.NhiemVu
                                .SelectMany(nhiemVu => nhiemVu.Product_IIs)
                                .Count(product => product.LoaiSanPham.Name == name)
                        })
                        .ToList()
                });

            return chuongTrinhProductCounts;
        }
        public IEnumerable<ChuongTrinhProductCounts> GetProduct_IIICountByCategory(int categoryId)
        {
            var distinctLoaiSanPhamNames = dataContext.LoaiSanPham.Where(x => x.DangSanPhamId == 3).Select(l => l.Name).ToList();

            var chuongTrinhProductCounts = dataContext.ChuongTrinh.Where(x => x.LoaiChuongTrinhId == categoryId).Include(x => x.NhiemVu)!
                .ThenInclude(x => x.Product_IIIs).ThenInclude(x => x.LoaiSanPham)
                .AsEnumerable()
                .Select(chuongTrinh => new ChuongTrinhProductCounts
                {
                    MaChuongTrinh = chuongTrinh.MaChuongTrinh,
                    LoaiSanPhamCounts = distinctLoaiSanPhamNames
                        .Select(name => new CountOfProduct
                        {
                            LoaiSp = name,
                            Count = chuongTrinh.NhiemVu
                                .SelectMany(nhiemVu => nhiemVu.Product_IIIs)
                                .Count(product => product.LoaiSanPham.Name == name)
                        })
                        .ToList()
                });

            return chuongTrinhProductCounts;
        }
        public IEnumerable<ChuongTrinhProductCounts> GetProduct_PostgraduateTrainingsCountByCategory(int categoryId)
        {
            var distinctLoaiSanPhamNames = Enum.GetNames(typeof(CapDaoTao)).ToList();

            var chuongTrinhProductCounts = dataContext.ChuongTrinh.Where(x => x.LoaiChuongTrinhId == categoryId).Include(x => x.NhiemVu)!
                .ThenInclude(x => x.Product_PostgraduateTrainings)
                .AsEnumerable()
                .Select(chuongTrinh => new ChuongTrinhProductCounts
                {
                    MaChuongTrinh = chuongTrinh.MaChuongTrinh,
                    LoaiSanPhamCounts = distinctLoaiSanPhamNames
                        .Select(name => new CountOfProduct
                        {
                            LoaiSp = name,
                            Count = chuongTrinh.NhiemVu
                                .SelectMany(nhiemVu => nhiemVu.Product_PostgraduateTrainings)
                                .Count(product => product.TrainingLevel.ToString() == name)
                        })
                        .ToList()
                });

            return chuongTrinhProductCounts;
        }
        public IEnumerable<Other_CountDTO> GetOtherProductsCountByCategory(int categoryId)
        {
            return dataContext.ChuongTrinh.Where(p => p.LoaiChuongTrinhId == categoryId).Include(x => x.NhiemVu)!
                    .ThenInclude(p => p.OtherProducts).AsEnumerable()
            .Select(p => new Other_CountDTO
            {
                MaChuongTrinh = p.MaChuongTrinh,
                Count = p.NhiemVu!.SelectMany(x => x.OtherProducts!).Count()
            });
        }

        public IEnumerable<ChuongTrinhProductCounts> GetOwnershipCountByCategory(int categoryId)
        {
            var distinctLoaiSanPhamNames = dataContext.LoaiSanPham.Where(x => x.DangSanPhamId == 5).Select(x => x.Name).ToList();

            var chuongTrinhProductCounts = dataContext.ChuongTrinh.Where(x => x.LoaiChuongTrinhId == categoryId).Include(x => x.NhiemVu)!
                    .ThenInclude(p => p.Ownerships).ThenInclude(x => x.LoaiSanPham)
                    .AsEnumerable()
                .Select(chuongTrinh => new ChuongTrinhProductCounts
                {
                    MaChuongTrinh = chuongTrinh.MaChuongTrinh,
                    LoaiSanPhamCounts = distinctLoaiSanPhamNames
                        .Select(name => new CountOfProduct
                        {
                            LoaiSp = name,
                            Count = chuongTrinh.NhiemVu
                                .SelectMany(nhiemVu => nhiemVu.Ownerships)
                                .Count(product => product.LoaiSanPham.Name == name)
                        })
                        .ToList()
                });

            return chuongTrinhProductCounts;
        }

        public IQueryable<ChuongTrinh_TinhHinhThucHienDTO> GetChuongTrinh_TinhHinhThucHienDTOs(int categoryId)
        {
            return dataContext.ChuongTrinh.Include(x => x.NhiemVu)!.ThenInclude(x => x.CoQuanChuTri_NhiemVu)!.ThenInclude(x => x.CoQuanChuTri)
                .Include(x => x.NhiemVu)!.ThenInclude(x => x.CaNhanThamGia)
                .Where(p => p.LoaiChuongTrinhId == categoryId)
                .Select(p => new ChuongTrinh_TinhHinhThucHienDTO
                {
                    MaChuongTrinh = p.MaChuongTrinh,
                    TaskCount = p.NhiemVu!.Count,
                    ChuyenMon_Total = p.NhiemVu.Sum(x => x.ThueKhoanChuyenMon_Khac) + p.NhiemVu.Sum(x => x.ThueKhoanChuyenMon_NganSachNhaNuoc),
                    VatLieuThietBi_Total = p.NhiemVu.Sum(x => x.ThietBiMayMoc_NganSachNhaNuoc) + p.NhiemVu.Sum(x => x.ThietBiMayMoc_Khac)
                                + p.NhiemVu.Sum(x => x.NguyenVatLieu_NganSachNhaNuoc) + p.NhiemVu.Sum(x => x.NguyenVatLieu_Khac),
                    HTQT_Total = p.NhiemVu.Sum(x => x.HTQT_NganSachNhaNuoc) + p.NhiemVu.Sum(x => x.HTQT_Khac),
                    KinhPhiThuHoi = p.NhiemVu.Sum(x => x.TongKinhPhiThuHoi),
                    KinhPhiNguonKhac_Total = p.NhiemVu.Sum(x => x.Khac_Total),
                    HocVi_CountDTOs = p.NhiemVu
                    .SelectMany(x => x.CaNhanThamGia!)
                    .GroupBy(x => x.HocVi!.Name)
                    .Select(x => new HocVi_CountDTO
                    {
                        HocVi = x.Key,
                        Count = x.Count()
                    }).ToList(),
                    CoQuanChuTri_DoanhNghiepCount = p.NhiemVu.SelectMany(x => x.CoQuanChuTri_NhiemVu!)
                        .Select(x => x.CoQuanChuTri!).Count(x => x.IsEnterprise == false),
                    CoQuanChuTri_NghienCuuCount = p.NhiemVu.SelectMany(x => x.CoQuanChuTri_NhiemVu!)
                        .Select(x => x.CoQuanChuTri!).Count(x => x.IsEnterprise == true),
                });
        }

        public IQueryable<NhiemVu_DungThucHienDTO> GetNhiemVu_DungThucHienDTOs(int categoryId)
        {
            return dataContext.ChuongTrinh.Include(x => x.NhiemVu)
                .Where(p => p.LoaiChuongTrinhId == categoryId)
                .Select(p => new NhiemVu_DungThucHienDTO
                {
                    MaChuongTrinh = p.MaChuongTrinh,
                    TaskCount = p.NhiemVu!.Count(x => x.Status == TrangThaiNhiemVu.Cancelled),
                    ChuyenMon_Total = p.NhiemVu!.Sum(x => x.ThueKhoanChuyenMon_NganSachNhaNuoc),
                    VatLieuThietBi_Total = p.NhiemVu!.Sum(x => x.ThietBiMayMoc_NganSachNhaNuoc)
                                + p.NhiemVu!.Sum(x => x.NguyenVatLieu_NganSachNhaNuoc),
                    HTQT_Total = p.NhiemVu!.Sum(x => x.HTQT_NganSachNhaNuoc),
                    KinhPhiNguonKhac_Total = p.NhiemVu!.Sum(x => x.Khac_Total),
                    DeTai = p.NhiemVu!.Count(x => x.Status == TrangThaiNhiemVu.Cancelled && x.Category == LoaiNhiemVu.Topic),
                    DuAn = p.NhiemVu!.Count(x => x.Status == TrangThaiNhiemVu.Cancelled && x.Category == LoaiNhiemVu.Project),
                    KinhPhi = p.NhiemVu!.Where(x => x.Status == TrangThaiNhiemVu.Cancelled && x.Category == LoaiNhiemVu.Topic)
                        .Sum(x => x.KinhPhi_Total)
                });
        }

        public IQueryable<ThongKeChuongTrinhDTO> GetThongKeChuongTrinhDTOs(int categoryId)
        {
            return dataContext.ChuongTrinh
                .Include(x => x.NhiemVu!)
                    .ThenInclude(x => x.Product_Is!)
                .Include(x => x.NhiemVu!)
                    .ThenInclude(x => x.Product_IIs!)
                .Include(x => x.NhiemVu!)
                    .ThenInclude(x => x.Product_IIIs)
                .Include(x => x.ChuyenGia)
                .Where(p => p.LoaiChuongTrinhId == categoryId)
                .Select(p => new ThongKeChuongTrinhDTO
                {
                    MaChuongTrinh = p.MaChuongTrinh,
                    DuAn = p.NhiemVu!.Count(x => x.Category == LoaiNhiemVu.Project),
                    DeTai = p.NhiemVu!.Count(x => x.Category == LoaiNhiemVu.Topic),
                    SoChuyenGia = p.ChuyenGia!.Count,
                    DangKy = p.NhiemVu!.SelectMany(x => x.Product_Is!).Count(x => x.IsRegistered)
                    + p.NhiemVu!.SelectMany(x => x.Product_IIs!).Count(x => x.IsRegistered)
                    + p.NhiemVu!.SelectMany(x => x.Product_IIIs!).Count(x => x.IsRegistered)
                    + p.NhiemVu!.SelectMany(x => x.Product_PostgraduateTrainings!).Count(x => x.IsRegistered)
                    + p.NhiemVu!.SelectMany(x => x.Ownerships!).Count(x => x.IsRegistered)
                    + p.NhiemVu!.SelectMany(x => x.OtherProducts!).Count(x => x.IsRegistered),

                    DatDuoc = p.NhiemVu!.SelectMany(x => x.Product_Is!).Count(x => x.IsSucceeded)
                    + p.NhiemVu!.SelectMany(x => x.Product_IIs!).Count(x => x.IsSucceeded)
                    + p.NhiemVu!.SelectMany(x => x.Product_IIIs!).Count(x => x.IsSucceeded)
                    + p.NhiemVu!.SelectMany(x => x.Product_PostgraduateTrainings!).Count(x => x.IsSucceeded)
                    + p.NhiemVu!.SelectMany(x => x.Ownerships!).Count(x => x.IsSucceeded)
                    + p.NhiemVu!.SelectMany(x => x.OtherProducts!).Count(x => x.IsSucceeded),

                    NoiBat = p.NhiemVu!.SelectMany(x => x.Product_Is!).Count(x => x.IsOutstanding)
                    + p.NhiemVu!.SelectMany(x => x.Product_IIs!).Count(x => x.IsOutstanding)
                    + p.NhiemVu!.SelectMany(x => x.Product_IIIs!).Count(x => x.IsOutstanding)
                    + p.NhiemVu!.SelectMany(x => x.Product_PostgraduateTrainings!).Count(x => x.IsOutstanding)
                    + p.NhiemVu!.SelectMany(x => x.Ownerships!).Count(x => x.IsRegistered)
                    + p.NhiemVu!.SelectMany(x => x.OtherProducts!).Count(x => x.IsOutstanding),

                    KinhPhi = p.NhiemVu!.Sum(x => x.KinhPhi_Total)
                });
        }

        public IQueryable<ChuongTrinh> GetChuongTrinhsByCategory(int? categoryId, int? periodId)
        {
            IQueryable<ChuongTrinh> query = dataContext.ChuongTrinh.Include(x => x.LoaiChuongTrinh);
            if (categoryId != null)
            {
                query = query.Where(x => x.LoaiChuongTrinhId == categoryId);
            }
            if (periodId != null)
            {
                query = query.Where(x => x.GiaiDoanId == periodId);
            }
            return query;
        }
    }
}
