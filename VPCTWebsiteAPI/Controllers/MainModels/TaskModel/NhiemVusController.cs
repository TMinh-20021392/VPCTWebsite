using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.DTO;
using VPCT.Core.Models.MainModels.TaskModel;
using VPCT.Core.Models.MainModels.TaskModel.Enums;
using VPCT.Core.ViewModel;
using VPCT.Repositories.Infrastructure;

namespace VPCTWebsiteAPI.Controllers.MainModels.TaskModel
{
    [Route("api/[controller]")]
    [ApiController]
    public class NhiemVusController(IUnitOfWork context) : ControllerBase
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
    }
}
