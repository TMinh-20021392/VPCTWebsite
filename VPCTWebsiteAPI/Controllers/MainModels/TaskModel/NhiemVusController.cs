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

        [HttpGet("downloadExcel/{CtId}")]
        public IActionResult PopulateExcelTemplate(int CtId)
        {
            int currentYear = DateTime.Now.Year;
            var data = context.NhiemVuRepository.TimKiemNhiemVu(programId: CtId).ToList();
            var templateFilePath = Path.Combine(hostEnvironment.ContentRootPath, "ThongKe", "abcxyz.xlsx");
            using (var templatePackage = new ExcelPackage(new FileInfo(templateFilePath)))
            {
                var worksheet = templatePackage.Workbook.Worksheets["DADLQG"];
                DADLQGSheeting(currentYear, data, worksheet);


                var fileBytes = templatePackage.GetAsByteArray();


                return File(fileBytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", $"_CẬP NHẬT KIỂM TRA, XÁC NHẬN NỘI DUNG, BÁO CÁO ĐỊNH KỲ NĂM {currentYear}.xlsx");
            }
        }

        private static void DADLQGSheeting(int currentYear, List<NhiemVu> data, ExcelWorksheet worksheet)
        {
            worksheet.Cells["B3"].Value = DateTime.Today.ToString("dd/MM/yyyy");
            worksheet.Cells["I5"].Value = $"Kế hoạch kinh phí năm {currentYear}\r\n(triệu đồng)";
            worksheet.Cells["J5"].Value = $"Kế hoạch kiểm tra {currentYear} (tính theo tháng/năm)\r\n(tích chọn)";
            worksheet.Cells["K5"].Value = $"Kế hoạch kiểm tra {currentYear} (tính theo tháng/năm)\r\n(tích chọn)";
            // Populate the data starting from row 6
            int rowIndex = 6;
            foreach (var item in data)
            {
                worksheet.Cells[rowIndex, 1].Value = rowIndex - 5; // A
                worksheet.Cells[rowIndex, 1].Style.Font.Name = "Calibri";
                worksheet.Cells[rowIndex, 1].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 1].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 1].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[rowIndex, 1].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                worksheet.Cells[rowIndex, 2].Value = item.MaNhiemVu; // B
                worksheet.Cells[rowIndex, 2].Style.Font.Name = "Calibri";
                worksheet.Cells[rowIndex, 2].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 2].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 2].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 2].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                worksheet.Cells[rowIndex, 2].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                worksheet.Cells[rowIndex, 3].Value = item.Name; // C
                worksheet.Cells[rowIndex, 3].Style.Font.Name = "Calibri";
                worksheet.Cells[rowIndex, 3].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 3].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 3].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 3].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                worksheet.Cells[rowIndex, 3].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                if (item.CoQuanChuTri != null)
                {
                    worksheet.Cells[rowIndex, 4].Value = item.CoQuanChuTri.Name; // D
                }
                worksheet.Cells[rowIndex, 4].Style.Font.Name = "Calibri";
                worksheet.Cells[rowIndex, 4].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 4].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 4].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 4].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                worksheet.Cells[rowIndex, 4].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                worksheet.Cells[rowIndex, 5].Value = item.President.Name; // E
                worksheet.Cells[rowIndex, 5].Style.Font.Name = "Calibri";
                worksheet.Cells[rowIndex, 5].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 5].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 5].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 5].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                worksheet.Cells[rowIndex, 5].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                worksheet.Cells[rowIndex, 6].Value = item.Planning_Specialist; // F
                worksheet.Cells[rowIndex, 6].Style.Font.Name = "Calibri";
                worksheet.Cells[rowIndex, 6].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 6].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 6].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 6].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                worksheet.Cells[rowIndex, 6].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                worksheet.Cells[rowIndex, 7].Value = item.KinhPhi_Total; // G
                worksheet.Cells[rowIndex, 7].Style.Font.Name = "Calibri";
                worksheet.Cells[rowIndex, 7].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 7].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 7].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 7].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
                worksheet.Cells[rowIndex, 7].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                worksheet.Cells[rowIndex, 8].Value = item.NganSachNhaNuoc_Total; // H
                worksheet.Cells[rowIndex, 8].Style.Font.Name = "Calibri";
                worksheet.Cells[rowIndex, 8].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 8].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 8].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 8].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[rowIndex, 8].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

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

                worksheet.Cells[rowIndex, 9].Style.Font.Name = "Calibri";
                worksheet.Cells[rowIndex, 9].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 9].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 9].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 9].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[rowIndex, 9].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                worksheet.Cells[rowIndex, 10].Style.Font.Name = "Calibri"; //J
                worksheet.Cells[rowIndex, 10].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 10].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 10].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 10].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                worksheet.Cells[rowIndex, 10].Style.VerticalAlignment = ExcelVerticalAlignment.Center;


                worksheet.Cells[rowIndex, 11].Formula = $"IF(J{rowIndex}>0,1,0)"; // K
                worksheet.Cells[rowIndex, 11].Style.Font.Name = "Calibri";
                worksheet.Cells[rowIndex, 11].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 11].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 11].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 11].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[rowIndex, 11].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                worksheet.Cells[rowIndex, 12].Style.Font.Name = "Calibri";//L
                worksheet.Cells[rowIndex, 12].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 12].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 12].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 12].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[rowIndex, 12].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                worksheet.Cells[rowIndex, 13].Style.Font.Name = "Calibri"; //M
                worksheet.Cells[rowIndex, 13].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 13].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 13].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 13].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[rowIndex, 13].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                if (item.StartDate_Month != null && item.StartDate_Year != null && item.EndDate_Month != null && item.EndDate_Year != null)
                {
                    worksheet.Cells[rowIndex, 14].Value = $"{item.StartDate_Month}/{item.StartDate_Year}-{item.EndDate_Month}/{item.EndDate_Year}"; //N
                }
                worksheet.Cells[rowIndex, 14].Style.Font.Name = "Calibri";
                worksheet.Cells[rowIndex, 14].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 14].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 14].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 14].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[rowIndex, 14].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                worksheet.Cells[rowIndex, 15].Formula = $"=IF(N{rowIndex}=\"\", \"\", LEFT(N{rowIndex}, IFERROR(FIND(\"-\", N{rowIndex}), LEN(N{rowIndex}))-1))"; //O
                worksheet.Cells[rowIndex, 15].Style.Font.Name = "Calibri";
                worksheet.Cells[rowIndex, 15].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 15].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 15].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 15].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[rowIndex, 15].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                worksheet.Cells[rowIndex, 16].Formula = $"=IF(ISBLANK(O{rowIndex}), \"\", EDATE(O{rowIndex}, 6))"; //P
                worksheet.Cells[rowIndex, 16].Style.Font.Name = "Calibri";
                worksheet.Cells[rowIndex, 16].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 16].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 16].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 16].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[rowIndex, 16].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                worksheet.Cells[rowIndex, 17].Formula = $"=IF(ISBLANK(O{rowIndex}), \"\", EDATE(O{rowIndex}, 12))"; //Q
                worksheet.Cells[rowIndex, 17].Style.Font.Name = "Calibri";
                worksheet.Cells[rowIndex, 17].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 17].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 17].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 17].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[rowIndex, 17].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                worksheet.Cells[rowIndex, 18].Formula = $"=IF(ISBLANK(O{rowIndex}), \"\", EDATE(O{rowIndex}, 18))"; //R
                worksheet.Cells[rowIndex, 18].Style.Font.Name = "Calibri";
                worksheet.Cells[rowIndex, 18].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 18].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 18].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 18].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[rowIndex, 18].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                worksheet.Cells[rowIndex, 19].Formula = $"=IF(ISBLANK(O{rowIndex}), \"\", EDATE(O{rowIndex}, 24))"; //S
                worksheet.Cells[rowIndex, 19].Style.Font.Name = "Calibri";
                worksheet.Cells[rowIndex, 19].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 19].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 19].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 19].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[rowIndex, 19].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                worksheet.Cells[rowIndex, 20].Formula = $"=IF(ISBLANK(O{rowIndex}), \"\", EDATE(O{rowIndex}, 30))"; //T
                worksheet.Cells[rowIndex, 20].Style.Font.Name = "Calibri";
                worksheet.Cells[rowIndex, 20].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 20].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 20].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 20].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[rowIndex, 20].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                worksheet.Cells[rowIndex, 21].Formula = $"=IF(ISBLANK(O{rowIndex}), \"\", EDATE(O{rowIndex}, 36))"; //U
                worksheet.Cells[rowIndex, 21].Style.Font.Name = "Calibri";
                worksheet.Cells[rowIndex, 21].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 21].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 21].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 21].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[rowIndex, 21].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                worksheet.Cells[rowIndex, 22].Formula = $"=IF(ISBLANK(O{rowIndex}), \"\", EDATE(O{rowIndex}, 42))"; //V
                worksheet.Cells[rowIndex, 22].Style.Font.Name = "Calibri";
                worksheet.Cells[rowIndex, 22].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 22].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 22].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 22].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[rowIndex, 22].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                worksheet.Cells[rowIndex, 23].Formula = $"=IF(ISBLANK(O{rowIndex}), \"\", EDATE(O{rowIndex}, 48))"; //W
                worksheet.Cells[rowIndex, 23].Style.Font.Name = "Calibri";
                worksheet.Cells[rowIndex, 23].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 23].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 23].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 23].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[rowIndex, 23].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                worksheet.Cells[rowIndex, 24].Formula = $"=IF(ISBLANK(O{rowIndex}), \"\", EDATE(O{rowIndex}, 54))"; //X
                worksheet.Cells[rowIndex, 24].Style.Font.Name = "Calibri";
                worksheet.Cells[rowIndex, 24].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 24].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 24].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 24].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[rowIndex, 24].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                worksheet.Cells[rowIndex, 25].Style.Font.Name = "Calibri"; //Y
                worksheet.Cells[rowIndex, 25].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 25].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 25].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 25].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[rowIndex, 25].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                worksheet.Cells[rowIndex, 26].Style.Font.Name = "Calibri"; //Z
                worksheet.Cells[rowIndex, 26].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 26].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 26].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 26].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[rowIndex, 26].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                worksheet.Cells[rowIndex, 27].Style.Font.Name = "Calibri"; //AA
                worksheet.Cells[rowIndex, 27].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 27].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 27].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 27].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[rowIndex, 27].Style.VerticalAlignment = ExcelVerticalAlignment.Center;


                worksheet.Cells[rowIndex, 28].Formula = $"=IF(ISBLANK(N{rowIndex}), \"\", RIGHT(N{rowIndex}, LEN(N{rowIndex}) - IFERROR(FIND(\"-\", N{rowIndex}), 0)))"; ; //AB
                worksheet.Cells[rowIndex, 28].Style.Font.Name = "Calibri";
                worksheet.Cells[rowIndex, 28].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 28].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 28].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 28].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[rowIndex, 28].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                if (item.Status == TrangThaiNhiemVu.DaNghiemThu)
                {
                    worksheet.Cells[rowIndex, 29].Value = 1; //AC
                }
                worksheet.Cells[rowIndex, 29].Style.Font.Name = "Calibri";
                worksheet.Cells[rowIndex, 29].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 29].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 29].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 29].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[rowIndex, 29].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                if (item.Status == TrangThaiNhiemVu.ChuaNghiemThu)
                {
                    worksheet.Cells[rowIndex, 30].Value = 1; //AD
                }
                worksheet.Cells[rowIndex, 30].Style.Font.Name = "Calibri";
                worksheet.Cells[rowIndex, 30].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 30].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 30].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 30].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[rowIndex, 30].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                if (item.Status == TrangThaiNhiemVu.Cancelled)
                {
                    worksheet.Cells[rowIndex, 31].Value = 1; //AE
                }
                worksheet.Cells[rowIndex, 31].Style.Font.Name = "Calibri";
                worksheet.Cells[rowIndex, 31].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 31].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 31].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 31].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[rowIndex, 31].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                if (item.Status == TrangThaiNhiemVu.Working)
                {
                    worksheet.Cells[rowIndex, 32].Value = 1; //AF
                }
                worksheet.Cells[rowIndex, 32].Style.Font.Name = "Calibri";
                worksheet.Cells[rowIndex, 32].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 32].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 32].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 32].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[rowIndex, 32].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                worksheet.Cells[rowIndex, 33].Style.Font.Name = "Calibri"; //AG
                worksheet.Cells[rowIndex, 33].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 33].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 33].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 33].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[rowIndex, 33].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                worksheet.Cells[rowIndex, 34].Formula = $"IF(AG{rowIndex}>0,1,0)"; //AH
                worksheet.Cells[rowIndex, 34].Style.Font.Name = "Calibri";
                worksheet.Cells[rowIndex, 34].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 34].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 34].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 34].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[rowIndex, 34].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                worksheet.Cells[rowIndex, 35].Style.Font.Name = "Calibri"; //AI
                worksheet.Cells[rowIndex, 35].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 35].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 35].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 35].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[rowIndex, 35].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                worksheet.Cells[rowIndex, 36].Formula = $"IF(AI{rowIndex}>0,1,0)"; //AJ
                worksheet.Cells[rowIndex, 36].Style.Font.Name = "Calibri";
                worksheet.Cells[rowIndex, 36].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 36].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 36].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 36].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[rowIndex, 36].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                worksheet.Cells[rowIndex, 37].Style.Font.Name = "Calibri"; //AK
                worksheet.Cells[rowIndex, 37].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 37].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 37].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 37].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[rowIndex, 37].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                worksheet.Cells[rowIndex, 38].Formula = $"IF(AK{rowIndex}>0,1,0)"; //AL
                worksheet.Cells[rowIndex, 38].Style.Font.Name = "Calibri";
                worksheet.Cells[rowIndex, 38].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 38].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 38].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 38].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[rowIndex, 38].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                worksheet.Cells[rowIndex, 39].Style.Font.Name = "Calibri"; //AM
                worksheet.Cells[rowIndex, 39].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 39].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 39].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 39].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[rowIndex, 39].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                worksheet.Cells[rowIndex, 40].Style.Font.Name = "Calibri"; //AN
                worksheet.Cells[rowIndex, 40].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 40].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 40].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 40].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                worksheet.Cells[rowIndex, 40].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                worksheet.Cells[rowIndex, 41].Style.Font.Name = "Calibri"; //AO
                worksheet.Cells[rowIndex, 41].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 41].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 41].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 41].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                worksheet.Cells[rowIndex, 41].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                worksheet.Cells[rowIndex, 42].Style.Font.Name = "Calibri"; //AP
                worksheet.Cells[rowIndex, 42].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 42].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 42].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 42].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                worksheet.Cells[rowIndex, 42].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                worksheet.Cells[rowIndex, 43].Formula = $"IF(AM{rowIndex}>0,1,0)"; //AQ
                worksheet.Cells[rowIndex, 43].Style.Font.Name = "Calibri";
                worksheet.Cells[rowIndex, 43].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 43].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 43].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 43].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[rowIndex, 43].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                worksheet.Cells[rowIndex, 44].Style.Font.Name = "Calibri"; //AR
                worksheet.Cells[rowIndex, 44].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 44].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 44].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 44].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                worksheet.Cells[rowIndex, 44].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

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
                worksheet.Cells[rowIndex, 45].Style.Font.Name = "Calibri";
                worksheet.Cells[rowIndex, 45].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 45].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 45].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 45].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[rowIndex, 45].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                worksheet.Cells[rowIndex, 46].Style.Font.Name = "Calibri"; //AT
                worksheet.Cells[rowIndex, 46].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 46].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 46].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 46].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                worksheet.Cells[rowIndex, 46].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                worksheet.Cells[rowIndex, 47].Style.Font.Name = "Calibri"; //AU
                worksheet.Cells[rowIndex, 47].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 47].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 47].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 47].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                worksheet.Cells[rowIndex, 47].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                worksheet.Cells[rowIndex, 48].Style.Font.Name = "Calibri"; //AV
                worksheet.Cells[rowIndex, 48].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 48].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 48].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 48].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                worksheet.Cells[rowIndex, 48].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                worksheet.Cells[rowIndex, 49].Style.Font.Name = "Calibri"; //AW
                worksheet.Cells[rowIndex, 49].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 49].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 49].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 49].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[rowIndex, 49].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                worksheet.Cells[rowIndex, 50].Style.Font.Name = "Calibri"; //AX
                worksheet.Cells[rowIndex, 50].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 50].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 50].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 50].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[rowIndex, 50].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                worksheet.Cells[rowIndex, 51].Style.Font.Name = "Calibri"; //AY
                worksheet.Cells[rowIndex, 51].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 51].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 51].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 51].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[rowIndex, 51].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                worksheet.Cells[rowIndex, 52].Style.Font.Name = "Calibri"; //AZ
                worksheet.Cells[rowIndex, 52].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 52].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 52].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 52].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[rowIndex, 52].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                worksheet.Cells[rowIndex, 53].Style.Font.Name = "Calibri"; //BA
                worksheet.Cells[rowIndex, 53].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 53].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 53].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 53].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[rowIndex, 53].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                worksheet.Cells[rowIndex, 54].Style.Font.Name = "Calibri"; //BB
                worksheet.Cells[rowIndex, 54].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 54].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 54].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 54].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[rowIndex, 54].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                worksheet.Cells[rowIndex, 55].Style.Font.Name = "Calibri"; //BC
                worksheet.Cells[rowIndex, 55].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 55].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 55].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 55].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[rowIndex, 55].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                worksheet.Cells[rowIndex, 56].Style.Font.Name = "Calibri"; //BD
                worksheet.Cells[rowIndex, 56].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 56].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 56].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 56].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[rowIndex, 56].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                worksheet.Cells[rowIndex, 57].Style.Font.Name = "Calibri"; //BE
                worksheet.Cells[rowIndex, 57].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 57].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 57].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 57].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[rowIndex, 57].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                worksheet.Cells[rowIndex, 58].Style.Font.Name = "Calibri"; //BF
                worksheet.Cells[rowIndex, 58].Style.Font.Size = 11;
                worksheet.Cells[rowIndex, 58].Style.Font.Bold = false;
                worksheet.Cells[rowIndex, 58].Style.Font.Italic = false;
                worksheet.Cells[rowIndex, 58].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                worksheet.Cells[rowIndex, 58].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                rowIndex++;
            }
        }
    }
}
