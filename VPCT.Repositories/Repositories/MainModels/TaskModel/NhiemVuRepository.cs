using LinqKit;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.DbContext;
using VPCT.Core.DTO;
using VPCT.Core.Models;
using VPCT.Core.Models.MainModels.TaskModel;
using VPCT.Core.Models.MainModels.TaskModel.Enums;
using VPCT.Repositories.Infrastructure;
using VPCT.Repositories.IRepositories.MainModels.TaskModel;

namespace VPCT.Repositories.Repositories
{
    public class NhiemVuRepository(VPCTDbContext context) : BaseRepository<NhiemVu>(context), INhiemVuRepository
    {
        public IQueryable<BaoCaoSoKet_TongHopPhanBoDTO> GetBaoCaoSoKet_TongHopPhanBoDTOs(int programId)
        {
            return dataContext.NhiemVu.Where(t => t.ChuongTrinhId == programId).Select(x => new BaoCaoSoKet_TongHopPhanBoDTO
            {
                MaNhiemVu = x.MaNhiemVu,
                Year = x.StartDate_Year
            });
        }

        public IQueryable<NhiemVu> TimKiemNhiemVu(string[]? keywords = null, string? searchTerm = null,
            int? categoryId = null, int? programId = null, int? periodId = null, KetQua? results = null,
            TrangThaiNhiemVu? taskStatuses = null)
        {
            GiaiDoan? period = dataContext.GiaiDoan.Find(periodId);

            IQueryable<NhiemVu> query = dataContext.NhiemVu.Include(x => x.ChuongTrinh)
                .Include(x => x.President)
                .Include(x => x.CoQuanChuTri)
                .Include(x => x.ChuyenNganh)
                .Include(x => x.CaNhanThamGia)
                .Include(x => x.Product_Is)
                .Include(x => x.Product_IIs)
                .Include(x => x.Product_IIIs)
                .Include(x => x.Product_PostgraduateTrainings)
                .Include(x => x.OtherProducts)
                .Include(x => x.Ownerships)
                .Include(x => x.ThanhLapDoanhNghiep)
                .Include(x => x.CoQuanQuanLyKinhPhi)
                .Include(x => x.CoQuanQuanLyNhiemVu);

            if (keywords != null && !string.IsNullOrEmpty(searchTerm))
            {
                var predicate = PredicateBuilder.New<NhiemVu>(false);

                foreach (string keyword in keywords)
                {
                    switch (keyword)
                    {
                        case "Name":
                            predicate = predicate.Or(t => t.Name.Contains(searchTerm));
                            break;
                        case "MaNhiemVu":
                            predicate = predicate.Or(t => t.MaNhiemVu.Contains(searchTerm));
                            break;
                        case "NoiDung":
                            predicate = predicate.Or(t => (t.NoiDung ?? "").Contains(searchTerm));
                            break;
                        case "MucTieu":
                            predicate = predicate.Or(t => (t.MucTieu ?? "").Contains(searchTerm));
                            break;
                        case "DiaChi":
                            predicate = predicate.Or(t => (t.Address ?? "").Contains(searchTerm));
                            break;
                        case "HieuQua":
                            predicate = predicate.Or(t => (t.HieuQua ?? "").Contains(searchTerm));
                            break;
                        case "NhanXet":
                            predicate = predicate.Or(t => (t.NhanXet ?? "").Contains(searchTerm));
                            break;
                        case "ChuongTrinh":
                            predicate = predicate.Or(t => t.ChuongTrinh!.MaChuongTrinh.Contains(searchTerm));
                            break;
                        case "ChuNhiem":
                            predicate = predicate.Or(t => t.President != null && t.President.Name.Contains(searchTerm));
                            break;
                        case "CoQuanChuTri":
                            predicate = predicate.Or(t => t.CoQuanChuTri != null && t.CoQuanChuTri.Name.Contains(searchTerm));
                            break;
                        case "ChuyenNganh":
                            predicate = predicate.Or(t => t.ChuyenNganh != null && t.ChuyenNganh.Name.Contains(searchTerm));
                            break;
                        case "CaNhan":
                            predicate = predicate.Or(t => t.CaNhanThamGia!.Any(x => x.Name.Contains(searchTerm)));
                            break;
                        case "NamBatDau":
                            if (int.TryParse(searchTerm, out int startyear))
                            {
                                predicate = predicate.Or(t => t.StartDate_Year == startyear);
                            }
                            break;
                        case "NamKetThuc":
                            if (int.TryParse(searchTerm, out int endyear))
                            {
                                predicate = predicate.Or(t => t.EndDate_Year == endyear);
                            }
                            break;
                        case "NamNghiemThu":
                            if (int.TryParse(searchTerm, out int year))
                            {
                                predicate = predicate.Or(t => t.NgiemThu_Year == year);
                            }
                            break;
                        case "SanPham":
                            predicate = predicate.Or(t => t.Product_Is!.Any(x => x.Name.Contains(searchTerm))
                                || t.Product_IIs!.Any(x => x.Name.Contains(searchTerm))
                                || t.Product_IIIs!.Any(x => x.Name.Contains(searchTerm))
                                || t.ThanhLapDoanhNghiep!.Any(x => x.Name.Contains(searchTerm))
                                || t.OtherProducts!.Any(x => x.Name.Contains(searchTerm)));
                            break;
                        case "QuanLyKinhPhi":
                            predicate = predicate.Or(t => t.CoQuanQuanLyKinhPhi != null && t.CoQuanQuanLyKinhPhi.Name.Contains(searchTerm));
                            break;
                        case "QuanLyNhiemVu":
                            predicate = predicate.Or(t => t.CoQuanQuanLyNhiemVu != null && t.CoQuanQuanLyNhiemVu.Name.Contains(searchTerm));
                            break;
                        case "LanhDao":
                            predicate = predicate.Or(t => (t.VPCT_Leader ?? "").Contains(searchTerm));
                            break;
                        case "ChuyenVienKeToan":
                            predicate = predicate.Or(t => (t.Accounting_Specialist ?? "").Contains(searchTerm));
                            break;
                        case "ChuyenVienTongHop":
                            predicate = predicate.Or(t => (t.Planning_Specialist ?? "").Contains(searchTerm));
                            break;
                        case "VuChuyenNganh":
                            predicate = predicate.Or(t => (t.DepartmentAdmin ?? "").Contains(searchTerm));
                            break;
                        case "ChuyenVienVuChuyenNganh":
                            predicate = predicate.Or(t => (t.DepartmentAdminSpecialist ?? "").Contains(searchTerm));
                            break;
                    }
                }

                query = query.Where(predicate);
            }

            if (period != null)
            {
                query = query.Where(t => (t.StartDate_Year != null && t.StartDate_Year >= period.Start && t.StartDate_Year <= period.End)
                            || (t.EndDate_Year != null && t.EndDate_Year >= period.Start && t.EndDate_Year <= period.End));
            }

            if (categoryId.HasValue)
            {
                query = query.Where(t => t.ChuongTrinh!.LoaiChuongTrinhId == categoryId);
            }

            if (programId.HasValue)
            {
                query = query.Where(t => t.ChuongTrinhId == programId);
            }

            if (results.HasValue)
            {
                query = query.Where(t => t.KetQua == results);
            }

            if (taskStatuses.HasValue)
            {
                query = query.Where(t => t.Status == taskStatuses);
            }

            return query;
        }
        public IQueryable<KetQuaNoiBatDTO> GetKetQuaNoiBatDTOs(int programId)
        {
            var query = dataContext.NhiemVu.Where(t => t.ChuongTrinhId == programId).Include(x => x.CoQuanChuTri).Include(x => x.Product_Is)
                .SelectMany(t => t.Product_Is!.Where(pi => pi.IsOutstanding).Select(pi => new KetQuaNoiBatDTO
                {
                    MaNhiemVu = t.MaNhiemVu,
                    Name = pi.Name,
                    HieuQua = pi.SocioEconomicEfficiency,
                    QuyMo = pi.Scale + "\n" + pi.Address,
                    CoQuanChuTri = t.CoQuanChuTri != null ? t.CoQuanChuTri.Name : null,
                }))
            .Union(dataContext.NhiemVu.Where(t => t.ChuongTrinhId == programId).Include(x => x.CoQuanChuTri).Include(x => x.Product_IIs)
                .SelectMany(t => t.Product_IIs!.Where(pi => pi.IsOutstanding).Select(pi => new KetQuaNoiBatDTO
                {
                    MaNhiemVu = t.MaNhiemVu,
                    Name = pi.Name,
                    HieuQua = pi.SocioEconomicEfficiency,
                    QuyMo = pi.Scale + "\n" + pi.Address,
                    CoQuanChuTri = t.CoQuanChuTri != null ? t.CoQuanChuTri.Name : null,
                    GhiChu = pi.GhiChu
                })))
            .Union(dataContext.NhiemVu.Where(t => t.ChuongTrinhId == programId).Include(x => x.CoQuanChuTri).Include(x => x.Product_IIIs)
                .SelectMany(t => t.Product_IIIs!.Where(pi => pi.IsOutstanding).Select(pi => new KetQuaNoiBatDTO
                {
                    MaNhiemVu = t.MaNhiemVu,
                    Name = pi.Name,
                    GhiChu = pi.GhiChu,
                    CoQuanChuTri = t.CoQuanChuTri != null ? t.CoQuanChuTri.Name : null,
                })))
            .Union(dataContext.NhiemVu.Where(t => t.ChuongTrinhId == programId).Include(x => x.CoQuanChuTri).Include(x => x.OtherProducts)
                .SelectMany(t => t.OtherProducts!.Where(pi => pi.IsOutstanding).Select(pi => new KetQuaNoiBatDTO
                {
                    MaNhiemVu = t.MaNhiemVu,
                    Name = pi.Name,
                    CoQuanChuTri = t.CoQuanChuTri != null ? t.CoQuanChuTri.Name : null,
                    GhiChu = pi.GhiChu
                })));

            return query;
        }

        public IQueryable<SanPhamThuongMaiHoaDTO> GetSanPhamThuongMaiHoaDTOs(int programId)
        {
            var query = dataContext.NhiemVu.Where(t => t.ChuongTrinhId == programId)
                .Include(x => x.Product_Is)
                .Include(x => x.Product_IIs)
                .Include(x => x.ThanhLapDoanhNghiep)
                .Select(t => new SanPhamThuongMaiHoaDTO
                {
                    MaNhiemVu = t.MaNhiemVu,
                    SoLuongTieuThu = t.Product_Is!.Where(x => x.IsConsumed).Sum(x => x.ConsumingQuantity)
                        + t.Product_IIs!.Where(x => x.IsConsumed).Sum(x => x.ConsumingQuantity),
                    SoTienTieuThu = t.Product_Is!.Where(x => x.IsConsumed).Sum(x => x.ConsumingAmount)
                        + t.Product_IIs!.Where(x => x.IsConsumed).Sum(x => x.ConsumingAmount),
                    SoLuongChuyenGiao = t.Product_Is!.Where(x => x.IsDelivered).Sum(x => x.DeliveryQuantity)
                        + t.Product_IIs!.Where(x => x.IsDelivered).Sum(x => x.DeliveryQuantity),
                    SoTienChuyenGiao = t.Product_Is!.Where(x => x.IsDelivered).Sum(x => x.DeliveryAmount)
                        + t.Product_IIs!.Where(x => x.IsDelivered).Sum(x => x.DeliveryAmount),
                    SoHopDongDichVu = t.Product_Is!.Count(x => x.ServiceProvisionContract) + t.Product_IIs!.Count(x => x.ServiceProvisionContract),
                    SoTienDichVu = t.Product_Is!.Where(x => x.ServiceProvisionContract).Sum(x => x.ContractAmount)
                        + t.Product_IIs!.Where(x => x.ServiceProvisionContract).Sum(x => x.ContractAmount),
                    TenDoanhNghiep = string.Join("\n", t.ThanhLapDoanhNghiep!.Select(x => x.Name).ToList()),
                    SoDoanhNghiep = t.ThanhLapDoanhNghiep!.Count
                });
            return query;
        }
    }
}
