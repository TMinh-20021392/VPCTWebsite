using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.ProductModel.TaskProduct;
using VPCT.Repositories.Infrastructure;

namespace VPCTWebsiteAPI.Controllers.MainModels.ProductModel.TaskProduct
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThanhLapDoanhNghiepsController(IUnitOfWork context) : ControllerBase
    {

        // GET: api/ThanhLapDoanhNghieps
        [HttpGet]
        public ActionResult<IEnumerable<ThanhLapDoanhNghiep>> GetThanhLapDoanhNghiep()
        {
            return context.ThanhLapDoanhNghiepRepository.GetAll().ToList();
        }

        // GET: api/ThanhLapDoanhNghieps/5
        [HttpGet("{id}")]
        public ActionResult<ThanhLapDoanhNghiep> GetThanhLapDoanhNghiep(int id)
        {
            var thanhLapDoanhNghiep = context.ThanhLapDoanhNghiepRepository.Find(id);

            if (thanhLapDoanhNghiep == null)
            {
                return NotFound();
            }

            return thanhLapDoanhNghiep;
        }
        [HttpGet("GetThanhLapDoanhNghiepByNhiemVu/{nhiemVuId}")]
        public ActionResult<IEnumerable<ThanhLapDoanhNghiep>> GetThanhLapDoanhNghiepByNhiemVu(int nhiemVuId)
        {
            var l = context.ThanhLapDoanhNghiepRepository.SearchThanhLapDoanhNghiepByNhiemVuId(nhiemVuId).ToList();

            if (l.Count == 0)
            {
                return NotFound();
            }

            return l;
        }
        // PUT: api/ThanhLapDoanhNghieps/5
        [HttpPut("{id}")]
        public IActionResult PutThanhLapDoanhNghiep(int id, ThanhLapDoanhNghiep thanhLapDoanhNghiep)
        {
            if (id != thanhLapDoanhNghiep.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context.ThanhLapDoanhNghiepRepository.Update(thanhLapDoanhNghiep);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ThanhLapDoanhNghiepExists(thanhLapDoanhNghiep.Id))
                    {
                        return NotFound();
                    }
                }
                return NoContent();
            }

            return BadRequest(ModelState);
        }

        // POST: api/ThanhLapDoanhNghieps
        [HttpPost]
        public ActionResult<ThanhLapDoanhNghiep> PostThanhLapDoanhNghiep(ThanhLapDoanhNghiep thanhLapDoanhNghiep)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.ThanhLapDoanhNghiepRepository.Create(thanhLapDoanhNghiep);
            context.SaveChanges();

            return CreatedAtAction("GetThanhLapDoanhNghiep", new { id = thanhLapDoanhNghiep.Id }, thanhLapDoanhNghiep);
        }

        // DELETE: api/ThanhLapDoanhNghieps/5
        [HttpDelete("{id}")]
        public IActionResult DeleteThanhLapDoanhNghiep(int id)
        {
            try
            {
                var thanhLapDoanhNghiep = context.ThanhLapDoanhNghiepRepository.Find(id);
                if (thanhLapDoanhNghiep == null)
                {
                    return NotFound();
                }

                context.ThanhLapDoanhNghiepRepository.Delete(thanhLapDoanhNghiep);
                context.SaveChanges();

                return NoContent();
            }
            catch (DbUpdateException)
            {
                return BadRequest("Foreign key constraint violation: Cannot delete this entity due to related records in other tables.");
            }
        }

        private bool ThanhLapDoanhNghiepExists(int id)
        {
            return (context.ThanhLapDoanhNghiepRepository.GetAll()?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
