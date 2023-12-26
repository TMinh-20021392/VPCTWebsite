using DocumentFormat.OpenXml;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using VPCT.Core.DTO;
using VPCT.Core.Models.MainModels.TaskModel;
using VPCT.Core.Models.MainModels.TaskModel.Enums;
using VPCT.Core.ViewModel;
using VPCT.Repositories.Infrastructure;

namespace VPCTWebsiteAPI.Controllers.MainModels.TaskModel
{
    [Route("api/[controller]")]
    [ApiController]
    public class NhiemVusController(IUnitOfWork context, IWebHostEnvironment hostEnvironment) : ControllerBase
    {

        // GET: api/NhiemVus
        [HttpGet]
        public ActionResult<IEnumerable<NhiemVu>> GetNhiemVu()
        {
            return context.NhiemVuRepository.GetAll().ToList();
        }

        // GET: api/NhiemVus/5
        [HttpGet("{id}")]
        public ActionResult<NhiemVu> GetNhiemVu(int id)
        {
            var nhiemVu = context.NhiemVuRepository.Find(id);

            if (nhiemVu == null)
            {
                return NotFound();
            }

            return nhiemVu;
        }


        [HttpGet("SearchCaNhanThamGiaByNhiemVu/{nvId}")]
        public ActionResult<IEnumerable<CaNhanThamGia>> SearchCaNhanThamGiaByNhiemVu(int nvId)
        {
            var l = context.CaNhanThamGiaRepository.SearchCaNhanThamGiaByNhiemVuId(nvId).ToList();

            if (l.Count == 0)
            {
                return NotFound();
            }

            return l;
        }

        [HttpGet("SearchCongVanNhiemVuByNhiemVu/{nvId}")]
        public ActionResult<IEnumerable<CongVanNhiemVu>> SearchCongVanNhiemVuByNhiemVu(int nvId)
        {
            var l = context.CongVanNhiemVuRepository.SearchCongVanNhiemVuByNhiemVuId(nvId).ToList();

            if (l.Count == 0)
            {
                return NotFound();
            }

            return l;
        }

        [HttpGet("SearchFileDinhKemByNhiemVu/{nvId}")]
        public ActionResult<IEnumerable<FileDinhKem>> SearchFileDinhKemByNhiemVu(int nvId)
        {
            var l = context.FileDinhKemRepository.SearchFileDinhKemByNhiemVuId(nvId).ToList();

            if (l.Count == 0)
            {
                return NotFound();
            }

            return l;
        }

        [HttpGet("SearchHoiDongKhoaHocByNhiemVu/{nvId}")]
        public ActionResult<IEnumerable<HoiDongKhoaHoc>> SearchHoiDongKhoaHocByNhiemVu(int nvId)
        {
            var l = context.HoiDongKhoaHocRepository.SearchHoiDongKhoaHocByNhiemVuId(nvId).ToList();

            if (l.Count == 0)
            {
                return NotFound();
            }

            return l;
        }

        [HttpGet("SearchLanDieuChinhByNhiemVu/{nvId}")]
        public ActionResult<IEnumerable<LanDieuChinh>> SearchLanDieuChinhByNhiemVu(int nvId)
        {
            var l = context.LanDieuChinhRepository.SearchLanDieuChinhByNhiemVuId(nvId).ToList();

            if (l.Count == 0)
            {
                return NotFound();
            }

            return l;
        }

        [HttpGet("SearchLanKiemTraByNhiemVu/{nvId}")]
        public ActionResult<IEnumerable<LanKiemTra>> SearchLanKiemTraByNhiemVu(int nvId)
        {
            var l = context.LanKiemTraRepository.SearchLanKiemTraByNhiemVuId(nvId).ToList();

            if (l.Count == 0)
            {
                return NotFound();
            }

            return l;
        }

        [HttpGet("SearchPhanBoNoiDungByNhiemVu/{nvId}")]
        public ActionResult<IEnumerable<PhanBoNoiDung>> SearchPhanBoNoiDungByNhiemVu(int nvId)
        {
            var l = context.PhanBoNoiDungRepository.SearchPhanBoNoiDungByNhiemVuId(nvId).ToList();

            if (l.Count == 0)
            {
                return NotFound();
            }

            return l;
        }

        [HttpGet("GetCoQuanChuTriByNhiemVu/{nvId}")]
        public ActionResult<IEnumerable<CoQuanChuTri_NhiemVu>> GetCoQuanChuTriByNhiemVu(int nvId)
        {
            var l = context.CoQuanChuTri_NhiemVuRepository.SearchCoQuanChuTri_NhiemVuByNhiemVuId(nvId).ToList();

            if (l.Count == 0)
            {
                return NotFound();
            }

            return l;
        }

        [HttpGet("GetDonViChuQuanByNhiemVu/{nvId}")]
        public ActionResult<IEnumerable<DonViChuQuan_NhiemVu>> GetDonViChuQuanByNhiemVu(int nvId)
        {
            var l = context.DonViChuQuan_NhiemVuRepository.SearchDonViChuQuan_NhiemVuByNhiemVuId(nvId).ToList();

            if (l.Count == 0)
            {
                return NotFound();
            }

            return l;
        }

        [HttpGet("GetBaoCaoSoKet_TongHopPhanBo/{nvId}")]
        public ActionResult<IEnumerable<BaoCaoSoKet_TongHopPhanBoDTO>> GetBaoCaoSoKet_TongHopPhanBoDTOs(int nvId)
        {
            var l = context.NhiemVuRepository.GetBaoCaoSoKet_TongHopPhanBoDTOs(nvId).ToList();

            if (l.Count == 0)
            {
                return NotFound();
            }

            return l;
        }

        [HttpGet("GetKetQuaNoiBat/{nvId}")]
        public ActionResult<IEnumerable<KetQuaNoiBatDTO>> GetKetQuaNoiBatDTOs(int nvId)
        {
            var l = context.NhiemVuRepository.GetKetQuaNoiBatDTOs(nvId).ToList();

            if (l.Count == 0)
            {
                return NotFound();
            }

            return l;
        }

        [HttpGet("GetSanPhamThuongMaiHoa/{nvId}")]
        public ActionResult<IEnumerable<SanPhamThuongMaiHoaDTO>> GetSanPhamThuongMaiHoaDTOs(int nvId)
        {
            var l = context.NhiemVuRepository.GetSanPhamThuongMaiHoaDTOs(nvId).ToList();

            if (l.Count == 0)
            {
                return NotFound();
            }

            return l;
        }

        [HttpGet("TimKiemNhiemVu")]
        public ActionResult<IEnumerable<NhiemVu>> TimKiemNhiemVu([FromQuery] string? searchTerm, [FromQuery] string[]? keywords, [FromQuery] int? categoryId, [FromQuery] int? programId, [FromQuery] int? periodId, [FromQuery] KetQua? results, [FromQuery] TrangThaiNhiemVu? taskStatuses)
        {
            var nhiemVuList = context.NhiemVuRepository.TimKiemNhiemVu(keywords, searchTerm, categoryId, programId, periodId, results, taskStatuses).ToList();

            if (nhiemVuList.Count == 0)
            {
                return NotFound();
            }

            return nhiemVuList;
        }


        // PUT: api/NhiemVus/5
        [HttpPut("{id}")]
        public IActionResult PutNhiemVu(int id, NhiemVu nhiemVu)
        {
            if (id != nhiemVu.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context.NhiemVuRepository.Update(nhiemVu);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NhiemVuExists(nhiemVu.Id))
                    {
                        return NotFound();
                    }
                }
                return NoContent();
            }

            return BadRequest(ModelState);
        }

        // POST: api/NhiemVus
        [HttpPost]
        public ActionResult<NhiemVu> PostNhiemVu(NhiemVu nhiemVu)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.NhiemVuRepository.Create(nhiemVu);
            context.SaveChanges();

            return CreatedAtAction("GetNhiemVu", new { id = nhiemVu.Id }, nhiemVu);
        }

        [HttpPost("{nhiemVuId}/DonViChuQuan")]
        public IActionResult AddDonViChuQuanInNhiemVu(int nhiemVuId, int donViChuQuanId, LoaiHoSo? filer)
        {
            try
            {
                var nhiemVu = context.NhiemVuRepository.Find(nhiemVuId);
                if (nhiemVu == null)
                {
                    return NotFound("NhiemVu not found");
                }

                var donViChuQuan = context.DonViChuQuanRepository.Find(donViChuQuanId);
                if (donViChuQuan == null)
                {
                    return NotFound("DonViChuQuan not found");
                }

                // Create the association between NhiemVu and DonViChuQuan
                var nhiemVuDonViChuQuan = new DonViChuQuan_NhiemVu
                {
                    NhiemVuId = nhiemVuId,
                    DonViChuQuanId = donViChuQuanId,
                    Filer = filer
                };

                context.DonViChuQuan_NhiemVuRepository.Create(nhiemVuDonViChuQuan);
                context.SaveChanges(); // Save changes

                return Ok("DonViChuQuan added to NhiemVu successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

        [HttpPut("{nhiemVuId}/DonViChuQuan/{donViChuQuanId}")]
        public IActionResult UpdateDonViChuQuanInNhiemVu(int nhiemVuId, int donViChuQuanId, DonViChuQuan_NhiemVuViewModel updatedAssociation)
        {
            try
            {
                var nhiemVu = context.NhiemVuRepository.Find(nhiemVuId);
                if (nhiemVu == null)
                {
                    return NotFound("NhiemVu not found");
                }

                var existingAssociation = context.DonViChuQuan_NhiemVuRepository.SearchDonViChuQuan_NhiemVuByNhiemVuId(nhiemVuId).FirstOrDefault(x => x.DonViChuQuanId == donViChuQuanId);
                if (existingAssociation != null)
                {
                    context.DonViChuQuan_NhiemVuRepository.Delete(existingAssociation);
                    context.SaveChanges();
                }
                var newAssociation = new DonViChuQuan_NhiemVu
                {
                    NhiemVuId = nhiemVuId,
                    DonViChuQuanId = updatedAssociation.DonViChuQuanId,
                    Filer = updatedAssociation.Filer
                };

                context.DonViChuQuan_NhiemVuRepository.Create(newAssociation);
                context.SaveChanges();
                return Ok("DonViChuQuan association in NhiemVu updated successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

        [HttpDelete("{nhiemVuId}/DonViChuQuan/{donViChuQuanId}")]
        public IActionResult RemoveDonViChuQuanFromNhiemVu(int nhiemVuId, int donViChuQuanId)
        {
            try
            {
                var nhiemVu = context.NhiemVuRepository.Find(nhiemVuId);
                if (nhiemVu == null)
                {
                    return NotFound("NhiemVu not found");
                }

                var donViChuQuan = context.DonViChuQuanRepository.Find(donViChuQuanId);
                if (donViChuQuan == null)
                {
                    return NotFound("DonViChuQuan not found");
                }

                // Remove the DonViChuQuan from the NhiemVu
                var nhiemVuDonViChuQuan = context.DonViChuQuan_NhiemVuRepository.SearchDonViChuQuan_NhiemVuByNhiemVuId(nhiemVuId).FirstOrDefault(x => x.DonViChuQuanId == donViChuQuanId);
                if (nhiemVuDonViChuQuan != null)
                {
                    context.DonViChuQuan_NhiemVuRepository.Delete(nhiemVuDonViChuQuan);
                    context.SaveChanges();
                    return Ok("DonViChuQuan removed from NhiemVu successfully");
                }
                else
                {
                    return NotFound("DonViChuQuan association not found in NhiemVu");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

        [HttpPost("{nhiemVuId}/CoQuanChuTri")]
        public IActionResult AddCoQuanChuTriInNhiemVu(int nhiemVuId, int coQuanChuTriId, int donViChuQuanId, LoaiHoSo? filer)
        {
            try
            {
                var nhiemVu = context.NhiemVuRepository.Find(nhiemVuId);
                if (nhiemVu == null)
                {
                    return NotFound("NhiemVu not found");
                }

                var coQuanChuTri = context.CoQuanChuTriRepository.Find(coQuanChuTriId);
                if (coQuanChuTri == null)
                {
                    return NotFound("CoQuanChuTri not found");
                }

                var donViChuQuan = context.DonViChuQuanRepository.Find(donViChuQuanId);
                if (donViChuQuan == null)
                {
                    return NotFound("DonViChuQuan not found");
                }

                var coQuanChuTri_NhiemVu = new CoQuanChuTri_NhiemVu
                {
                    NhiemVuId = nhiemVuId,
                    CoQuanChuTriId = coQuanChuTriId,
                    DonViChuQuanId = donViChuQuanId,
                    Filer = filer
                };

                context.CoQuanChuTri_NhiemVuRepository.Create(coQuanChuTri_NhiemVu);
                context.SaveChanges();

                return Ok("CoQuanChuTri added to NhiemVu successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

        [HttpPut("{nhiemVuId}/CoQuanChuTri/{coQuanChuTriId}/DonViChuQuan/{donViChuQuanId}")]
        public IActionResult UpdateCoQuanChuTriInNhiemVu(int nhiemVuId, int coQuanChuTriId, int donViChuQuanId, CoQuanChuTri_NhiemVuViewModel updatedAssociation)
        {
            try
            {
                var nhiemVu = context.NhiemVuRepository.Find(nhiemVuId);
                if (nhiemVu == null)
                {
                    return NotFound("NhiemVu not found");
                }

                var existingAssociation = context.CoQuanChuTri_NhiemVuRepository.SearchCoQuanChuTri_NhiemVuByNhiemVuId(nhiemVuId).FirstOrDefault(x => x.CoQuanChuTriId == coQuanChuTriId && x.DonViChuQuanId == donViChuQuanId);
                if (existingAssociation != null)
                {
                    context.CoQuanChuTri_NhiemVuRepository.Delete(existingAssociation);
                    context.SaveChanges();
                }

                var newAssociation = new CoQuanChuTri_NhiemVu
                {
                    NhiemVuId = nhiemVuId,
                    CoQuanChuTriId = updatedAssociation.CoQuanChuTriId,
                    DonViChuQuanId = updatedAssociation.DonViChuQuanId,
                    Filer = updatedAssociation.Filer
                };

                context.CoQuanChuTri_NhiemVuRepository.Create(newAssociation);
                context.SaveChanges();

                return Ok("CoQuanChuTri association in NhiemVu updated successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

        [HttpDelete("{nhiemVuId}/CoQuanChuTri/{coQuanChuTriId}/DonViChuQuan/{donViChuQuanId}")]
        public IActionResult DeleteCoQuanChuTriDonViChuQuanFromNhiemVu(int nhiemVuId, int coQuanChuTriId, int donViChuQuanId)
        {
            try
            {
                var existingAssociation = context.CoQuanChuTri_NhiemVuRepository.SearchCoQuanChuTri_NhiemVuByNhiemVuId(nhiemVuId)
                    .FirstOrDefault(x => x.CoQuanChuTriId == coQuanChuTriId && x.DonViChuQuanId == donViChuQuanId);
                if (existingAssociation != null)
                {
                    context.CoQuanChuTri_NhiemVuRepository.Delete(existingAssociation);
                    context.SaveChanges();
                    return Ok("CoQuanChuTri-DVChuQuan association in NhiemVu deleted successfully");
                }
                else
                {
                    return NotFound("CoQuanChuTri-DVChuQuan association in NhiemVu not found");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

        // DELETE: api/NhiemVus/5
        [HttpDelete("{id}")]
        public IActionResult DeleteNhiemVu(int id)
        {
            try
            {
                var nhiemVu = context.NhiemVuRepository.Find(id);
                if (nhiemVu == null)
                {
                    return NotFound();
                }

                context.NhiemVuRepository.Delete(nhiemVu);
                context.SaveChanges();

                return NoContent();
            }
            catch (DbUpdateException)
            {
                return BadRequest("Foreign key constraint violation: Cannot delete this entity due to related records in other tables.");
            }
        }

        private bool NhiemVuExists(int id)
        {
            return (context.NhiemVuRepository.GetAll()?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        [HttpGet("downloadExcel")]
        public IActionResult PopulateExcelTemplate([FromQuery] int? loaiCtId, [FromQuery] int? CtId)
        {
            int currentYear = DateTime.Now.Year;
            var data = context.NhiemVuRepository.TimKiemNhiemVu(programId: CtId, categoryId: loaiCtId).ToList();
            var templateFilePath = Path.Combine(hostEnvironment.ContentRootPath, "ThongKe", "abcxyz.xlsx");
            using (var templatePackage = new ExcelPackage(new FileInfo(templateFilePath)))
            {
                if (loaiCtId == 2 || ((CtId != null) && context.ChuongTrinhRepository.Find(CtId).LoaiChuongTrinhId == 2))
                {
                    var worksheet = templatePackage.Workbook.Worksheets["DADLQG"];
                    DADLQGSheeting(currentYear, data, worksheet);
                    worksheet.Select();
                }

                if (loaiCtId == 1 || ((CtId != null) && context.ChuongTrinhRepository.Find(CtId).LoaiChuongTrinhId == 1))
                {
                    var worksheet2 = templatePackage.Workbook.Worksheets["KC4.0"];
                    KCFourSheeting(currentYear, data, worksheet2);
                    worksheet2.Select();
                }
                var fileBytes = templatePackage.GetAsByteArray();


                return File(fileBytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", $"_CẬP NHẬT KIỂM TRA, XÁC NHẬN NỘI DUNG, BÁO CÁO ĐỊNH KỲ NĂM {currentYear}.xlsx");
            }
        }

        private static void KCFourSheeting(int currentYear, List<NhiemVu> data, ExcelWorksheet worksheet)
        {
            int starter = 4;
            int rowIndex = starter;
            DateTime? startDate = null, endDate = null;
            foreach (var item in data)
            {
                FromAToM(currentYear, worksheet, starter, rowIndex, item);
                ApplyCenterFont(worksheet, rowIndex, 14); //N

                if (item.StartDate_Month != null && item.StartDate_Year != null && item.EndDate_Month != null && item.EndDate_Year != null)
                {
                    worksheet.Cells[rowIndex, 15].Value = $"{item.StartDate_Month}/{item.StartDate_Year}-{item.EndDate_Month}/{item.EndDate_Year}"; //O
                    startDate = new(item.StartDate_Year.Value, item.StartDate_Month.Value, 1, 0, 0, 0, DateTimeKind.Unspecified);
                    endDate = new(item.EndDate_Year.Value, item.EndDate_Month.Value, 1, 0, 0, 0, DateTimeKind.Unspecified);
                }
                ApplyCenterFont(worksheet, rowIndex, 15);

                worksheet.Cells[rowIndex, 16].Formula = $"=IF(O{rowIndex}=\"\", \"\", LEFT(O{rowIndex}, IFERROR(FIND(\"-\", O{rowIndex}), LEN(O{rowIndex}))-1))"; //P
                ApplyCenterFont(worksheet, rowIndex, 16);

                if (startDate != null)
                {
                    DateTime dateP = startDate.Value.AddMonths(6);
                    if (dateP <= endDate)
                    {
                        worksheet.Cells[rowIndex, 17].Formula = $"=IF(ISBLANK(P{rowIndex}), \"\", EDATE(P{rowIndex}, 6))"; //Q
                    }
                }
                ApplyCenterFont(worksheet, rowIndex, 17);

                if (startDate != null)
                {
                    DateTime dateP = startDate.Value.AddMonths(12);
                    if (dateP <= endDate)
                    {
                        worksheet.Cells[rowIndex, 18].Formula = $"=IF(ISBLANK(P{rowIndex}), \"\", EDATE(P{rowIndex}, 12))"; //R
                    }
                }
                ApplyCenterFont(worksheet, rowIndex, 18);

                if (startDate != null)
                {
                    DateTime dateP = startDate.Value.AddMonths(18);
                    if (dateP <= endDate)
                    {
                        worksheet.Cells[rowIndex, 19].Formula = $"=IF(ISBLANK(P{rowIndex}), \"\", EDATE(P{rowIndex}, 18))"; //S
                    }
                }
                ApplyCenterFont(worksheet, rowIndex, 19);

                if (startDate != null)
                {
                    DateTime dateP = startDate.Value.AddMonths(24);
                    if (dateP <= endDate)
                    {
                        worksheet.Cells[rowIndex, 20].Formula = $"=IF(ISBLANK(P{rowIndex}), \"\", EDATE(P{rowIndex}, 24))"; //T
                    }
                }
                ApplyCenterFont(worksheet, rowIndex, 20);

                if (startDate != null)
                {
                    DateTime dateP = startDate.Value.AddMonths(30);
                    if (dateP <= endDate)
                    {
                        worksheet.Cells[rowIndex, 21].Formula = $"=IF(ISBLANK(P{rowIndex}), \"\", EDATE(P{rowIndex}, 30))"; //U
                    }
                }
                ApplyCenterFont(worksheet, rowIndex, 21);

                if (startDate != null)
                {
                    DateTime dateP = startDate.Value.AddMonths(36);
                    if (dateP <= endDate)
                    {
                        worksheet.Cells[rowIndex, 22].Formula = $"=IF(ISBLANK(P{rowIndex}), \"\", EDATE(P{rowIndex}, 36))"; //V
                    }
                }
                ApplyCenterFont(worksheet, rowIndex, 22);

                if (startDate != null)
                {
                    DateTime dateP = startDate.Value.AddMonths(42);
                    if (dateP <= endDate)
                    {
                        worksheet.Cells[rowIndex, 23].Formula = $"=IF(ISBLANK(P{rowIndex}), \"\", EDATE(P{rowIndex}, 42))"; //W
                    }
                }
                ApplyCenterFont(worksheet, rowIndex, 23);

                ApplyCenterFont(worksheet, rowIndex, 24); //X

                worksheet.Cells[rowIndex, 25].Formula = $"=IF(ISBLANK(O{rowIndex}), \"\", RIGHT(O{rowIndex}, LEN(O{rowIndex}) - IFERROR(FIND(\"-\", O{rowIndex}), 0)))"; //Y
                ApplyCenterFont(worksheet, rowIndex, 25);

                if (item.Status == TrangThaiNhiemVu.DaNghiemThu)
                {
                    worksheet.Cells[rowIndex, 26].Value = 1; //Z
                }
                ApplyCenterFont(worksheet, rowIndex, 26);

                if (item.Status == TrangThaiNhiemVu.ChuaNghiemThu)
                {
                    worksheet.Cells[rowIndex, 27].Value = 1; //AA
                }
                ApplyCenterFont(worksheet, rowIndex, 27);

                if (item.Status == TrangThaiNhiemVu.Cancelled)
                {
                    worksheet.Cells[rowIndex, 28].Value = 1; //AB
                }
                ApplyCenterFont(worksheet, rowIndex, 28);

                if (item.Status == TrangThaiNhiemVu.Working)
                {
                    worksheet.Cells[rowIndex, 29].Value = 1; //AC
                }
                ApplyCenterFont(worksheet, rowIndex, 29);

                ApplyCenterFont(worksheet, rowIndex, 30); //AD

                worksheet.Cells[rowIndex, 31].Formula = $"IF(AD{rowIndex}>0,1,0)"; //AE
                ApplyCenterFont(worksheet, rowIndex, 31);

                ApplyCenterFont(worksheet, rowIndex, 32); //AF

                worksheet.Cells[rowIndex, 33].Formula = $"IF(AF{rowIndex}>0,1,0)"; //AG
                ApplyCenterFont(worksheet, rowIndex, 33);

                ApplyCenterFont(worksheet, rowIndex, 34); //AH

                ApplyLeftFont(worksheet, rowIndex, 35); //AI

                ApplyLeftFont(worksheet, rowIndex, 36); //AJ
                ApplyLeftFont(worksheet, rowIndex, 37); //AK

                if (item.CoQuanQuanLyNhiemVuId == 2)
                {
                    worksheet.Cells[rowIndex, 38].Value = "ĐP"; //AL
                }
                else if (item.CoQuanQuanLyNhiemVuId == 4)
                {
                    worksheet.Cells[rowIndex, 38].Value = "CNC";
                }
                else if (item.CoQuanQuanLyNhiemVuId == 5)
                {
                    worksheet.Cells[rowIndex, 38].Value = "CNN";
                }
                else if (item.CoQuanQuanLyNhiemVuId == 3)
                {
                    worksheet.Cells[rowIndex, 38].Value = "XNT";
                }
                ApplyCenterFont(worksheet, rowIndex, 38);

                ApplyLeftFont(worksheet, rowIndex, 39); //AM
                ApplyLeftFont(worksheet, rowIndex, 40); //AN
                ApplyLeftFont(worksheet, rowIndex, 41); //AO

                ApplyCenterFont(worksheet, rowIndex, 42); //AP

                ApplyCenterFont(worksheet, rowIndex, 43); //AQ

                ApplyCenterFont(worksheet, rowIndex, 44); //AR

                ApplyCenterFont(worksheet, rowIndex, 45); //AS

                ApplyCenterFont(worksheet, rowIndex, 46); //AT
                ApplyCenterFont(worksheet, rowIndex, 47); //AU
                ApplyCenterFont(worksheet, rowIndex, 48); //AV
                ApplyCenterFont(worksheet, rowIndex, 49); //AW
                ApplyCenterFont(worksheet, rowIndex, 50); //AX
                ApplyLeftFont(worksheet, rowIndex, 51); //AY
                rowIndex++;
            }
        }
        private static void DADLQGSheeting(int currentYear, List<NhiemVu> data, ExcelWorksheet worksheet)
        {
            worksheet.Cells["B3"].Value = DateTime.Today.ToString("dd/MM/yyyy");
            worksheet.Cells["I5"].Value = $"Kế hoạch kinh phí năm {currentYear}\r\n(triệu đồng)";
            worksheet.Cells["J5"].Value = $"Kế hoạch kiểm tra {currentYear} (tính theo tháng/năm)\r\n(tích chọn)";
            worksheet.Cells["K5"].Value = $"Kế hoạch kiểm tra {currentYear} (tính theo tháng/năm)\r\n(tích chọn)";
            int starter = 6;
            int rowIndex = starter;
            DateTime? startDate = null, endDate = null;
            foreach (var item in data)
            {
                FromAToM(currentYear, worksheet, starter, rowIndex, item);

                if (item.StartDate_Month != null && item.StartDate_Year != null && item.EndDate_Month != null && item.EndDate_Year != null)
                {
                    worksheet.Cells[rowIndex, 14].Value = $"{item.StartDate_Month}/{item.StartDate_Year}-{item.EndDate_Month}/{item.EndDate_Year}"; //N
                    startDate = new(item.StartDate_Year.Value, item.StartDate_Month.Value, 1, 0, 0, 0, DateTimeKind.Unspecified);
                    endDate = new(item.EndDate_Year.Value, item.EndDate_Month.Value, 1, 0, 0, 0, DateTimeKind.Unspecified);
                }
                ApplyCenterFont(worksheet, rowIndex, 14);

                worksheet.Cells[rowIndex, 15].Formula = $"=IF(N{rowIndex}=\"\", \"\", LEFT(N{rowIndex}, IFERROR(FIND(\"-\", N{rowIndex}), LEN(N{rowIndex}))-1))"; //O
                ApplyCenterFont(worksheet, rowIndex, 15);

                if (startDate != null)
                {
                    DateTime dateP = startDate.Value.AddMonths(6);
                    if (dateP <= endDate)
                    {
                        worksheet.Cells[rowIndex, 16].Formula = $"=IF(ISBLANK(O{rowIndex}), \"\", EDATE(O{rowIndex}, 6))"; //P
                    }
                }
                ApplyCenterFont(worksheet, rowIndex, 16);

                if (startDate != null)
                {
                    DateTime dateP = startDate.Value.AddMonths(12);
                    if (dateP <= endDate)
                    {
                        worksheet.Cells[rowIndex, 17].Formula = $"=IF(ISBLANK(O{rowIndex}), \"\", EDATE(O{rowIndex}, 12))"; //Q
                    }
                }
                ApplyCenterFont(worksheet, rowIndex, 17);

                if (startDate != null)
                {
                    DateTime dateP = startDate.Value.AddMonths(18);
                    if (dateP <= endDate)
                    {
                        worksheet.Cells[rowIndex, 18].Formula = $"=IF(ISBLANK(O{rowIndex}), \"\", EDATE(O{rowIndex}, 18))"; //R
                    }
                }
                ApplyCenterFont(worksheet, rowIndex, 18);

                if (startDate != null)
                {
                    DateTime dateP = startDate.Value.AddMonths(24);
                    if (dateP <= endDate)
                    {
                        worksheet.Cells[rowIndex, 19].Formula = $"=IF(ISBLANK(O{rowIndex}), \"\", EDATE(O{rowIndex}, 24))"; //S
                    }
                }
                ApplyCenterFont(worksheet, rowIndex, 19);

                if (startDate != null)
                {
                    DateTime dateP = startDate.Value.AddMonths(30);
                    if (dateP <= endDate)
                    {
                        worksheet.Cells[rowIndex, 20].Formula = $"=IF(ISBLANK(O{rowIndex}), \"\", EDATE(O{rowIndex}, 30))"; //T
                    }
                }
                ApplyCenterFont(worksheet, rowIndex, 20);

                if (startDate != null)
                {
                    DateTime dateP = startDate.Value.AddMonths(36);
                    if (dateP <= endDate)
                    {
                        worksheet.Cells[rowIndex, 21].Formula = $"=IF(ISBLANK(O{rowIndex}), \"\", EDATE(O{rowIndex}, 36))"; //U
                    }
                }
                ApplyCenterFont(worksheet, rowIndex, 21);

                if (startDate != null)
                {
                    DateTime dateP = startDate.Value.AddMonths(42);
                    if (dateP <= endDate)
                    {
                        worksheet.Cells[rowIndex, 22].Formula = $"=IF(ISBLANK(O{rowIndex}), \"\", EDATE(O{rowIndex}, 42))"; //V
                    }
                }
                ApplyCenterFont(worksheet, rowIndex, 22);

                if (startDate != null)
                {
                    DateTime dateP = startDate.Value.AddMonths(48);
                    if (dateP <= endDate)
                    {
                        worksheet.Cells[rowIndex, 23].Formula = $"=IF(ISBLANK(O{rowIndex}), \"\", EDATE(O{rowIndex}, 48))"; //W
                    }
                }
                ApplyCenterFont(worksheet, rowIndex, 23);

                if (startDate != null)
                {
                    DateTime dateP = startDate.Value.AddMonths(54);
                    if (dateP <= endDate)
                    {
                        worksheet.Cells[rowIndex, 24].Formula = $"=IF(ISBLANK(O{rowIndex}), \"\", EDATE(O{rowIndex}, 54))"; //X
                    }
                }
                ApplyCenterFont(worksheet, rowIndex, 24);

                if (startDate != null)
                {
                    DateTime dateP = startDate.Value.AddMonths(60);
                    if (dateP <= endDate)
                    {
                        worksheet.Cells[rowIndex, 24].Formula = $"=IF(ISBLANK(O{rowIndex}), \"\", EDATE(O{rowIndex}, 60))"; //Y
                    }
                }
                ApplyCenterFont(worksheet, rowIndex, 25);

                ApplyCenterFont(worksheet, rowIndex, 26); //Z

                ApplyCenterFont(worksheet, rowIndex, 27); //AA


                worksheet.Cells[rowIndex, 28].Formula = $"=IF(ISBLANK(N{rowIndex}), \"\", RIGHT(N{rowIndex}, LEN(N{rowIndex}) - IFERROR(FIND(\"-\", N{rowIndex}), 0)))"; //AB
                ApplyCenterFont(worksheet, rowIndex, 28);

                if (item.Status == TrangThaiNhiemVu.DaNghiemThu)
                {
                    worksheet.Cells[rowIndex, 29].Value = 1; //AC
                }
                ApplyCenterFont(worksheet, rowIndex, 29);

                if (item.Status == TrangThaiNhiemVu.ChuaNghiemThu)
                {
                    worksheet.Cells[rowIndex, 30].Value = 1; //AD
                }
                ApplyCenterFont(worksheet, rowIndex, 30);

                if (item.Status == TrangThaiNhiemVu.Cancelled)
                {
                    worksheet.Cells[rowIndex, 31].Value = 1; //AE
                }
                ApplyCenterFont(worksheet, rowIndex, 31);

                if (item.Status == TrangThaiNhiemVu.Working)
                {
                    worksheet.Cells[rowIndex, 32].Value = 1; //AF
                }
                ApplyCenterFont(worksheet, rowIndex, 32);

                ApplyCenterFont(worksheet, rowIndex, 33); //AG

                worksheet.Cells[rowIndex, 34].Formula = $"IF(AG{rowIndex}>0,1,0)"; //AH
                ApplyCenterFont(worksheet, rowIndex, 34);

                worksheet.Cells[rowIndex, 35].Style.Font.Name = "Calibri"; //AI
                ApplyCenterFont(worksheet, rowIndex, 35);

                worksheet.Cells[rowIndex, 36].Formula = $"IF(AI{rowIndex}>0,1,0)"; //AJ
                ApplyCenterFont(worksheet, rowIndex, 36);

                worksheet.Cells[rowIndex, 37].Style.Font.Name = "Calibri"; //AK
                ApplyCenterFont(worksheet, rowIndex, 37);

                worksheet.Cells[rowIndex, 38].Formula = $"IF(AK{rowIndex}>0,1,0)"; //AL
                ApplyCenterFont(worksheet, rowIndex, 38);

                ApplyCenterFont(worksheet, rowIndex, 39); //AM

                ApplyLeftFont(worksheet, rowIndex, 40); //AN

                ApplyLeftFont(worksheet, rowIndex, 41); //AO

                ApplyLeftFont(worksheet, rowIndex, 42); //AP

                worksheet.Cells[rowIndex, 43].Formula = $"IF(AM{rowIndex}>0,1,0)"; //AQ
                ApplyCenterFont(worksheet, rowIndex, 43);

                ApplyLeftFont(worksheet, rowIndex, 44); //AR

                if (item.CoQuanQuanLyNhiemVuId == 2)
                {
                    worksheet.Cells[rowIndex, 45].Value = "ĐP"; //AS
                }
                else if (item.CoQuanQuanLyNhiemVuId == 4)
                {
                    worksheet.Cells[rowIndex, 45].Value = "CNC";
                }
                else if (item.CoQuanQuanLyNhiemVuId == 5)
                {
                    worksheet.Cells[rowIndex, 45].Value = "CNN";
                }
                else if (item.CoQuanQuanLyNhiemVuId == 3)
                {
                    worksheet.Cells[rowIndex, 45].Value = "XNT";
                }
                ApplyCenterFont(worksheet, rowIndex, 45);

                ApplyLeftFont(worksheet, rowIndex, 46); //AT

                ApplyLeftFont(worksheet, rowIndex, 47); //AU

                ApplyLeftFont(worksheet, rowIndex, 48); //AV

                ApplyCenterFont(worksheet, rowIndex, 49); //AW

                ApplyCenterFont(worksheet, rowIndex, 50); //AX

                ApplyCenterFont(worksheet, rowIndex, 51); //AY

                ApplyCenterFont(worksheet, rowIndex, 52); //AZ

                ApplyCenterFont(worksheet, rowIndex, 53); //BA

                ApplyCenterFont(worksheet, rowIndex, 54); //BB

                ApplyCenterFont(worksheet, rowIndex, 55); //BC

                ApplyCenterFont(worksheet, rowIndex, 56); //BD

                ApplyCenterFont(worksheet, rowIndex, 57); //BE

                ApplyLeftFont(worksheet, rowIndex, 58); //BF

                rowIndex++;
            }
        }
        private static void ApplyLeftFont(ExcelWorksheet worksheet, int rowIndex, int x)
        {
            worksheet.Cells[rowIndex, x].Style.Font.Name = "Calibri";
            worksheet.Cells[rowIndex, x].Style.Font.Size = 11;
            worksheet.Cells[rowIndex, x].Style.Font.Bold = false;
            worksheet.Cells[rowIndex, x].Style.Font.Italic = false;
            worksheet.Cells[rowIndex, x].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
            worksheet.Cells[rowIndex, x].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
        }
        private static void ApplyCenterFont(ExcelWorksheet worksheet, int rowIndex, int x)
        {
            worksheet.Cells[rowIndex, x].Style.Font.Name = "Calibri";
            worksheet.Cells[rowIndex, x].Style.Font.Size = 11;
            worksheet.Cells[rowIndex, x].Style.Font.Bold = false;
            worksheet.Cells[rowIndex, x].Style.Font.Italic = false;
            worksheet.Cells[rowIndex, x].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            worksheet.Cells[rowIndex, x].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
        }
        private static void ApplyRightFont(ExcelWorksheet worksheet, int rowIndex, int x)
        {
            worksheet.Cells[rowIndex, x].Style.Font.Name = "Calibri";
            worksheet.Cells[rowIndex, x].Style.Font.Size = 11;
            worksheet.Cells[rowIndex, x].Style.Font.Bold = false;
            worksheet.Cells[rowIndex, x].Style.Font.Italic = false;
            worksheet.Cells[rowIndex, x].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
            worksheet.Cells[rowIndex, x].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
        }
        private static void FromAToM(int currentYear, ExcelWorksheet worksheet, int starter, int rowIndex, NhiemVu item)
        {
            worksheet.Cells[rowIndex, 1].Value = rowIndex - (starter - 1); // A
            ApplyCenterFont(worksheet, rowIndex, 1);

            worksheet.Cells[rowIndex, 2].Value = item.MaNhiemVu; // B
            ApplyLeftFont(worksheet, rowIndex, 2);

            worksheet.Cells[rowIndex, 3].Value = item.Name; // C
            ApplyLeftFont(worksheet, rowIndex, 3);

            if (item.CoQuanChuTri != null)
            {
                worksheet.Cells[rowIndex, 4].Value = item.CoQuanChuTri.Name; // D
            }
            ApplyLeftFont(worksheet, rowIndex, 4);

            worksheet.Cells[rowIndex, 5].Value = item.President!.Name; // E
            ApplyLeftFont(worksheet, rowIndex, 5);

            worksheet.Cells[rowIndex, 6].Value = item.Planning_Specialist; // F
            ApplyLeftFont(worksheet, rowIndex, 6);

            worksheet.Cells[rowIndex, 7].Value = item.KinhPhi_Total; // G
            ApplyRightFont(worksheet, rowIndex, 7);

            worksheet.Cells[rowIndex, 8].Value = item.NganSachNhaNuoc_Total; // H
            ApplyCenterFont(worksheet, rowIndex, 8);

            if (item.FundingPlan_FirstYearMonths == currentYear)
            {
                worksheet.Cells[rowIndex, 9].Value = item.FundingPlan_FirstYear; //I
            }
            else if (item.FundingPlan_SecondYearMonths == currentYear)
            {
                worksheet.Cells[rowIndex, 9].Value = item.FundingPlan_SecondYear;
            }
            else if (item.FundingPlan_ThirdYearMonths == currentYear)
            {
                worksheet.Cells[rowIndex, 9].Value = item.FundingPlan_ThirdYear;
            }
            else if (item.FundingPlan_FourthYearMonths == currentYear)
            {
                worksheet.Cells[rowIndex, 9].Value = item.FundingPlan_FourthYear;
            }
            else if (item.FundingPlan_FifthYearMonths == currentYear)
            {
                worksheet.Cells[rowIndex, 9].Value = item.FundingPlan_FifthYear;
            }
            else if (item.FundingPlan_SixthYearMonths == currentYear)
            {
                worksheet.Cells[rowIndex, 9].Value = item.FundingPlan_SixthYear;
            }
            else
            {
                worksheet.Cells[rowIndex, 9].Value = string.Empty;
            }
            ApplyCenterFont(worksheet, rowIndex, 9);

            worksheet.Cells[rowIndex, 10].Style.Font.Name = "Calibri"; //J
            ApplyLeftFont(worksheet, rowIndex, 10);


            worksheet.Cells[rowIndex, 11].Formula = $"IF(J{rowIndex}>0,1,0)"; // K
            ApplyCenterFont(worksheet, rowIndex, 11);

            worksheet.Cells[rowIndex, 12].Style.Font.Name = "Calibri";//L
            ApplyCenterFont(worksheet, rowIndex, 12);

            worksheet.Cells[rowIndex, 13].Style.Font.Name = "Calibri"; //M
            ApplyCenterFont(worksheet, rowIndex, 13);
        }
    }
}
