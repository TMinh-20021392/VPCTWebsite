using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.TaskModel;
using VPCT.Core.Models.MainModels.TaskModel.Enums;
using VPCT.Core.ViewModel;
using VPCT.Repositories.Infrastructure;

namespace VPCTWebsiteAPI.Controllers.MainModels.TaskModel
{
    [Route("api/[controller]")]
    [ApiController]
    public class HoiDongKhoaHocsController(IUnitOfWork context) : ControllerBase
    {

        // GET: api/HoiDongKhoaHocs
        [HttpGet]
        public ActionResult<IEnumerable<HoiDongKhoaHoc>> GetHoiDongKhoaHoc()
        {
            return context.HoiDongKhoaHocRepository.GetAll().ToList();
        }

        // GET: api/HoiDongKhoaHocs/5
        [HttpGet("{id}")]
        public ActionResult<HoiDongKhoaHoc> GetHoiDongKhoaHoc(int id)
        {
            var hoiDongKhoaHoc = context.HoiDongKhoaHocRepository.Find(id);

            if (hoiDongKhoaHoc == null)
            {
                return NotFound();
            }

            return hoiDongKhoaHoc;
        }
        [HttpGet("{nvId}/ChuyenGia")]
        public ActionResult<IEnumerable<HoiDongKhoaHoc_ChuyenGia>> GetChuyenGiaByHoiDongKhoaHoc(int nvId)
        {
            var l = context.HoiDongKhoaHoc_ChuyenGiaRepository.SearchHoiDongKhoaHoc_ChuyenGiaByHoiDongKhoaHocId(nvId).ToList();

            if (l.Count == 0)
            {
                return NotFound();
            }

            return l;
        }

        [HttpPost("{hoiDongKhoaHocId}/ChuyenGia")]
        public IActionResult AddChuyenGiaInHoiDongKhoaHoc(int hoiDongKhoaHocId, int chuyenGiaId, ChucDanhHoiDong chucDanh)
        {
            try
            {
                var hoiDongKhoaHoc = context.HoiDongKhoaHocRepository.Find(hoiDongKhoaHocId);
                if (hoiDongKhoaHoc == null)
                {
                    return NotFound("HoiDongKhoaHoc not found");
                }

                var chuyenGia = context.ChuyenGiaRepository.Find(chuyenGiaId);
                if (chuyenGia == null)
                {
                    return NotFound("ChuyenGia not found");
                }

                // Create a new entry in the HoiDongKhoaHoc_ChuyenGia join table with the ChucDanhHoiDong
                var hoiDongKhoaHocChuyenGia = new HoiDongKhoaHoc_ChuyenGia
                {
                    HoiDongKhoaHocId = hoiDongKhoaHocId,
                    ChuyenGiaId = chuyenGiaId,
                    ChucDanh = chucDanh
                };

                context.HoiDongKhoaHoc_ChuyenGiaRepository.Create(hoiDongKhoaHocChuyenGia);
                context.SaveChanges(); // Save changes

                return Ok("ChuyenGia added to HoiDongKhoaHoc successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

        [HttpPut("{hoiDongKhoaHocId}/ChuyenGia/{chuyenGiaId}")]
        public IActionResult UpdateChuyenGiaInHoiDongKhoaHoc(int hoiDongKhoaHocId, int chuyenGiaId, HoiDongKhoaHoc_ChuyenGiaViewModel updatedAssociation)
        {
            try
            {
                var hoiDongKhoaHoc = context.HoiDongKhoaHocRepository.Find(hoiDongKhoaHocId);
                if (hoiDongKhoaHoc == null)
                {
                    return NotFound("HoiDongKhoaHoc not found");
                }

                var chuyenGia = context.ChuyenGiaRepository.Find(chuyenGiaId);
                if (chuyenGia == null)
                {
                    return NotFound("ChuyenGia not found");
                }

                var existingAssociation = context.HoiDongKhoaHoc_ChuyenGiaRepository.SearchHoiDongKhoaHoc_ChuyenGiaByHoiDongKhoaHocId(hoiDongKhoaHocId).FirstOrDefault(x => x.ChuyenGiaId == chuyenGiaId);
                if (existingAssociation != null)
                {
                    context.HoiDongKhoaHoc_ChuyenGiaRepository.Delete(existingAssociation);
                    context.SaveChanges();

                }
                var newAssociation = new HoiDongKhoaHoc_ChuyenGia
                {
                    HoiDongKhoaHocId = hoiDongKhoaHocId,
                    ChuyenGiaId = updatedAssociation.ChuyenGiaId,
                    ChucDanh = updatedAssociation.ChucDanh
                };

                context.HoiDongKhoaHoc_ChuyenGiaRepository.Create(newAssociation);
                context.SaveChanges();
                return Ok("ChuyenGia association in HoiDongKhoaHoc updated successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

        [HttpDelete("{hoiDongKhoaHocId}/ChuyenGia/{chuyenGiaId}")]
        public IActionResult RemoveChuyenGiaFromHoiDongKhoaHoc(int hoiDongKhoaHocId, int chuyenGiaId)
        {
            try
            {
                var hoiDongKhoaHoc = context.HoiDongKhoaHocRepository.Find(hoiDongKhoaHocId);
                if (hoiDongKhoaHoc == null)
                {
                    return NotFound("HoiDongKhoaHoc not found");
                }

                var chuyenGia = context.ChuyenGiaRepository.Find(chuyenGiaId);
                if (chuyenGia == null)
                {
                    return NotFound("ChuyenGia not found");
                }

                // Remove the ChuyenGia from the HoiDongKhoaHoc
                var hoiDongKhoaHocChuyenGia = context.HoiDongKhoaHoc_ChuyenGiaRepository.SearchHoiDongKhoaHoc_ChuyenGiaByHoiDongKhoaHocId(hoiDongKhoaHocId).FirstOrDefault(x => x.ChuyenGiaId == chuyenGiaId);
                if (hoiDongKhoaHocChuyenGia != null)
                {
                    context.HoiDongKhoaHoc_ChuyenGiaRepository.Delete(hoiDongKhoaHocChuyenGia);
                    context.SaveChanges();
                    return Ok("ChuyenGia removed from HoiDongKhoaHoc successfully");
                }
                else
                {
                    return NotFound("ChuyenGia not found in HoiDongKhoaHoc");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

        // PUT: api/HoiDongKhoaHocs/5
        [HttpPut("{id}")]
        public IActionResult PutHoiDongKhoaHoc(int id, HoiDongKhoaHoc hoiDongKhoaHoc)
        {
            if (id != hoiDongKhoaHoc.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context.HoiDongKhoaHocRepository.Update(hoiDongKhoaHoc);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HoiDongKhoaHocExists(hoiDongKhoaHoc.Id))
                    {
                        return NotFound();
                    }
                }
                return NoContent();
            }

            return BadRequest(ModelState);
        }

        // POST: api/HoiDongKhoaHocs
        [HttpPost]
        public ActionResult<HoiDongKhoaHoc> PostHoiDongKhoaHoc(HoiDongKhoaHoc hoiDongKhoaHoc)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.HoiDongKhoaHocRepository.Create(hoiDongKhoaHoc);
            context.SaveChanges();

            return CreatedAtAction("GetHoiDongKhoaHoc", new { id = hoiDongKhoaHoc.Id }, hoiDongKhoaHoc);
        }

        // DELETE: api/HoiDongKhoaHocs/5
        [HttpDelete("{id}")]
        public IActionResult DeleteHoiDongKhoaHoc(int id)
        {
            var hoiDongKhoaHoc = context.HoiDongKhoaHocRepository.Find(id);
            if (hoiDongKhoaHoc == null)
            {
                return NotFound();
            }

            context.HoiDongKhoaHocRepository.Delete(hoiDongKhoaHoc);
            context.SaveChanges();

            return NoContent();
        }

        private bool HoiDongKhoaHocExists(int id)
        {
            return (context.HoiDongKhoaHocRepository.GetAll()?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
