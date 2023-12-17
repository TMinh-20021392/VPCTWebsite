using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.DTO;
using VPCT.Core.Models.MainModels.DepartmentModel;
using VPCT.Core.Models.MainModels.ProgramModel;
using VPCT.Core.ViewModel;
using VPCT.Repositories.Infrastructure;

namespace VPCTWebsiteAPI.Controllers.MainModels.ProgramModel
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChuongTrinhsController(IUnitOfWork context) : ControllerBase
    {

        // GET: api/ChuongTrinhs
        [HttpGet]
        public ActionResult<IEnumerable<ChuongTrinh>> GetChuongTrinh()
        {
            return context.ChuongTrinhRepository.GetAll()
                .Include(x => x.LoaiChuongTrinh)
                .Include(x => x.CoQuanChuTri)
                .Include(x => x.GiaiDoan).ToList();
        }

        // GET: api/ChuongTrinhs/5
        [HttpGet("{id}")]
        public ActionResult<ChuongTrinh> GetChuongTrinh(int id)
        {
            var chuongTrinh = context.ChuongTrinhRepository.GetAll()
                .Include(x => x.LoaiChuongTrinh)
                .Include(x => x.CoQuanChuTri)
                .Include(x => x.GiaiDoan).FirstOrDefault(x => x.Id == id);

            if (chuongTrinh == null)
            {
                return NotFound();
            }

            return chuongTrinh;
        }

        [HttpGet("GetCoQuanQuanLyByChuongTrinh/{ctId}")]
        public ActionResult<IEnumerable<CoQuanQuanLy?>> GetCoQuanQuanLyByChuongTrinh(int ctId)
        {
            var l = context.ChuongTrinh_CoQuanQuanLyRepository.SearchCoQuanQuanLyByChuongTrinh(ctId).ToList();

            if (l.Count == 0)
            {
                return NotFound();
            }

            return l;
        }

        [HttpGet("GetChuongTrinhByLoaiChuongTrinh/{ctId}")]
        public ActionResult<IEnumerable<ChuongTrinh>> GetChuongTrinhByLoaiChuongTrinh(int? ctId, int? period)
        {
            var l = context.ChuongTrinhRepository.GetChuongTrinhsByCategory(ctId, period).Include(x => x.LoaiChuongTrinh)
                .Include(x => x.CoQuanChuTri)
                .Include(x => x.GiaiDoan).ToList();

            if (l.Count == 0)
            {
                return NotFound();
            }

            return l;
        }

        [HttpGet("GetProduct_ICountByCategory/{ctId}")]
        public ActionResult<IEnumerable<ChuongTrinhProductCounts>> GetProduct_ICountByCategory(int ctId)
        {
            var l = context.ChuongTrinhRepository.GetProduct_ICountByCategory(ctId).ToList();

            if (l.Count == 0)
            {
                return NotFound();
            }

            return l;
        }

        [HttpGet("GetProduct_IICountByCategory/{ctId}")]
        public ActionResult<IEnumerable<ChuongTrinhProductCounts>> GetProduct_IICountByCategory(int ctId)
        {
            var l = context.ChuongTrinhRepository.GetProduct_IICountByCategory(ctId).ToList();

            if (l.Count == 0)
            {
                return NotFound();
            }

            return l;
        }

        [HttpGet("GetProduct_IIICountByCategory/{ctId}")]
        public ActionResult<IEnumerable<ChuongTrinhProductCounts>> GetProduct_IIICountByCategory(int ctId)
        {
            var l = context.ChuongTrinhRepository.GetProduct_IIICountByCategory(ctId).ToList();

            if (l.Count == 0)
            {
                return NotFound();
            }

            return l;
        }

        [HttpGet("GetProduct_PostgraduateTrainingsCountByCategory/{ctId}")]
        public ActionResult<IEnumerable<ChuongTrinhProductCounts>> GetProduct_PostgraduateTrainingsCountByCategory(int ctId)
        {
            var l = context.ChuongTrinhRepository.GetProduct_PostgraduateTrainingsCountByCategory(ctId).ToList();

            if (l.Count == 0)
            {
                return NotFound();
            }

            return l;
        }

        [HttpGet("GetOwnershipCountByCategory/{ctId}")]
        public ActionResult<IEnumerable<ChuongTrinhProductCounts>> GetOwnershipCountByCategory(int ctId)
        {
            var l = context.ChuongTrinhRepository.GetOwnershipCountByCategory(ctId).ToList();

            if (l.Count == 0)
            {
                return NotFound();
            }

            return l;
        }

        [HttpGet("GetOtherProductsCountByCategory/{ctId}")]
        public ActionResult<IEnumerable<Other_CountDTO>> GetOtherProductsCountByCategory(int ctId)
        {
            var l = context.ChuongTrinhRepository.GetOtherProductsCountByCategory(ctId).ToList();

            if (l.Count == 0)
            {
                return NotFound();
            }

            return l;
        }

        [HttpGet("GetChuongTrinh_TinhHinhThucHienByCategory/{ctId}")]
        public ActionResult<IEnumerable<ChuongTrinh_TinhHinhThucHienDTO>> GetChuongTrinh_TinhHinhThucHienDTOs(int ctId)
        {
            var l = context.ChuongTrinhRepository.GetChuongTrinh_TinhHinhThucHienDTOs(ctId).ToList();

            if (l.Count == 0)
            {
                return NotFound();
            }

            return l;
        }

        [HttpGet("GetNhiemVu_DungThucHienByCategory/{ctId}")]
        public ActionResult<IEnumerable<NhiemVu_DungThucHienDTO>> GetNhiemVu_DungThucHienDTOs(int ctId)
        {
            var l = context.ChuongTrinhRepository.GetNhiemVu_DungThucHienDTOs(ctId).ToList();

            if (l.Count == 0)
            {
                return NotFound();
            }

            return l;
        }

        [HttpGet("GetThongKeChuongTrinhByCategory/{ctId}")]
        public ActionResult<IEnumerable<ThongKeChuongTrinhDTO>> GetThongKeChuongTrinhDTOs(int ctId)
        {
            var l = context.ChuongTrinhRepository.GetThongKeChuongTrinhDTOs(ctId).ToList();

            if (l.Count == 0)
            {
                return NotFound();
            }

            return l;
        }

        // PUT: api/ChuongTrinhs/5
        [HttpPut("{id}")]
        public IActionResult PutChuongTrinh(int id, ChuongTrinh chuongTrinh)
        {
            if (id != chuongTrinh.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context.ChuongTrinhRepository.Update(chuongTrinh);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChuongTrinhExists(chuongTrinh.Id))
                    {
                        return NotFound();
                    }
                }
                return NoContent();
            }

            return BadRequest(ModelState);
        }

        // POST: api/ChuongTrinhs
        [HttpPost]
        public ActionResult<ChuongTrinh> PostChuongTrinh(ChuongTrinh chuongTrinh)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.ChuongTrinhRepository.Create(chuongTrinh);
            context.SaveChanges();

            return CreatedAtAction("GetChuongTrinh", new { id = chuongTrinh.Id }, chuongTrinh);
        }

        [HttpPost("{chuongTrinhId}/CoQuanQuanLy")]
        public IActionResult AddCoQuanQuanLyInChuongTrinh(int chuongTrinhId, int coQuanQuanLyId)
        {
            try
            {
                var chuongTrinh = context.ChuongTrinhRepository.Find(chuongTrinhId);
                if (chuongTrinh == null)
                {
                    return NotFound("ChuongTrinh not found");
                }

                var coQuanQuanLy = context.CoQuanQuanLyRepository.Find(coQuanQuanLyId);
                if (coQuanQuanLy == null)
                {
                    return NotFound("CoQuanQuanLy not found");
                }

                // Create a new entry in the ChuongTrinh_CoQuanQuanLy join table with the ChucDanh
                var chuongTrinhCoQuanQuanLy = new ChuongTrinh_CoQuanQuanLy
                {
                    ChuongTrinhId = chuongTrinhId,
                    CoQuanQuanLyId = coQuanQuanLyId
                };

                context.ChuongTrinh_CoQuanQuanLyRepository.Create(chuongTrinhCoQuanQuanLy);
                context.SaveChanges(); // Save changes

                return Ok("CoQuanQuanLy added to ChuongTrinh successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

        [HttpPut("{chuongTrinhId}/CoQuanQuanLy/{coQuanQuanLyId}")]
        public IActionResult UpdateCoQuanQuanLyInChuongTrinh(int chuongTrinhId, int coQuanQuanLyId, ChuongTrinh_CoQuanQuanLyViewModel updatedAssociation)
        {
            try
            {
                var chuongTrinh = context.ChuongTrinhRepository.Find(chuongTrinhId);
                if (chuongTrinh == null)
                {
                    return NotFound("ChuongTrinh not found");
                }

                var coQuanQuanLy = context.CoQuanQuanLyRepository.Find(coQuanQuanLyId);
                if (coQuanQuanLy == null)
                {
                    return NotFound("CoQuanQuanLy not found");
                }

                var existingAssociation = context.ChuongTrinh_CoQuanQuanLyRepository.SearchCoQuanQuanLyByChuongTrinh(chuongTrinhId).FirstOrDefault(x => x.Id == coQuanQuanLyId);
                if (existingAssociation != null)
                {
                    context.ChuongTrinh_CoQuanQuanLyRepository.Delete(existingAssociation);
                    context.SaveChanges();
                    var newAssociation = new ChuongTrinh_CoQuanQuanLy
                    {
                        ChuongTrinhId = chuongTrinhId,
                        CoQuanQuanLyId = updatedAssociation.CoQuanId
                    };

                    context.ChuongTrinh_CoQuanQuanLyRepository.Create(newAssociation);
                    context.SaveChanges();
                    return Ok("CoQuanQuanLy association in ChuongTrinh updated successfully");
                }
                else
                {
                    var newAssociation = new ChuongTrinh_CoQuanQuanLy
                    {
                        ChuongTrinhId = chuongTrinhId,
                        CoQuanQuanLyId = updatedAssociation.CoQuanId
                    };

                    context.ChuongTrinh_CoQuanQuanLyRepository.Create(newAssociation);
                    context.SaveChanges();
                    return Ok("CoQuanQuanLy association in ChuongTrinh updated successfully");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

        [HttpDelete("{chuongTrinhId}/CoQuanQuanLy/{coQuanQuanLyId}")]
        public IActionResult RemoveCoQuanQuanLyFromChuongTrinh(int chuongTrinhId, int coQuanQuanLyId)
        {
            try
            {
                var chuongTrinh = context.ChuongTrinhRepository.Find(chuongTrinhId);
                if (chuongTrinh == null)
                {
                    return NotFound("ChuongTrinh not found");
                }

                var coQuanQuanLy = context.CoQuanQuanLyRepository.Find(coQuanQuanLyId);
                if (coQuanQuanLy == null)
                {
                    return NotFound("CoQuanQuanLy not found");
                }

                // Remove the CoQuanQuanLy from the ChuongTrinh
                var chuongTrinhCoQuanQuanLy = context.ChuongTrinh_CoQuanQuanLyRepository.SearchCoQuanQuanLyByChuongTrinh(chuongTrinhId).FirstOrDefault(x => x.Id == coQuanQuanLyId);
                if (chuongTrinhCoQuanQuanLy != null)
                {
                    context.ChuongTrinh_CoQuanQuanLyRepository.Delete(chuongTrinhCoQuanQuanLy);
                    context.SaveChanges();
                    return Ok("CoQuanQuanLy removed from ChuongTrinh successfully");
                }
                else
                {
                    return NotFound("CoQuanQuanLy association not found in ChuongTrinh");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

        // DELETE: api/ChuongTrinhs/5
        [HttpDelete("{id}")]
        public IActionResult DeleteChuongTrinh(int id)
        {
            var chuongTrinh = context.ChuongTrinhRepository.Find(id);
            if (chuongTrinh == null)
            {
                return NotFound();
            }

            context.ChuongTrinhRepository.Delete(chuongTrinh);
            context.SaveChanges();

            return NoContent();
        }

        private bool ChuongTrinhExists(int id)
        {
            return (context.ChuongTrinhRepository.GetAll()?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
