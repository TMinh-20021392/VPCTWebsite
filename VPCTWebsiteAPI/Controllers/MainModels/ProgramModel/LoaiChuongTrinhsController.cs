using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.ProgramModel;
using VPCT.Repositories.Infrastructure;

namespace VPCTWebsiteAPI.Controllers.MainModels.ProgramModel
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoaiChuongTrinhsController(IUnitOfWork context) : ControllerBase
    {

        // GET: api/LoaiChuongTrinhs
        [HttpGet]
        public ActionResult<IEnumerable<LoaiChuongTrinh>> GetLoaiChuongTrinh()
        {
            return context.LoaiChuongTrinhRepository.GetAll().ToList();
        }

        // GET: api/LoaiChuongTrinhs/5
        [HttpGet("{id}")]
        public ActionResult<LoaiChuongTrinh> GetLoaiChuongTrinh(int id)
        {
            var loaiChuongTrinh = context.LoaiChuongTrinhRepository.Find(id);

            if (loaiChuongTrinh == null)
            {
                return NotFound();
            }

            return loaiChuongTrinh;
        }

        // PUT: api/LoaiChuongTrinhs/5
        [HttpPut("{id}")]
        public IActionResult PutLoaiChuongTrinh(int id, LoaiChuongTrinh loaiChuongTrinh)
        {
            if (id != loaiChuongTrinh.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context.LoaiChuongTrinhRepository.Update(loaiChuongTrinh);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoaiChuongTrinhExists(loaiChuongTrinh.Id))
                    {
                        return NotFound();
                    }
                }
                return NoContent();
            }

            return BadRequest(ModelState);
        }

        // POST: api/LoaiChuongTrinhs
        [HttpPost]
        public ActionResult<LoaiChuongTrinh> PostLoaiChuongTrinh(LoaiChuongTrinh loaiChuongTrinh)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.LoaiChuongTrinhRepository.Create(loaiChuongTrinh);
            context.SaveChanges();

            return CreatedAtAction("GetLoaiChuongTrinh", new { id = loaiChuongTrinh.Id }, loaiChuongTrinh);
        }

        // DELETE: api/LoaiChuongTrinhs/5
        [HttpDelete("{id}")]
        public IActionResult DeleteLoaiChuongTrinh(int id)
        {
            try
            {
                var loaiChuongTrinh = context.LoaiChuongTrinhRepository.Find(id);
                if (loaiChuongTrinh == null)
                {
                    return NotFound();
                }

                context.LoaiChuongTrinhRepository.Delete(loaiChuongTrinh);
                context.SaveChanges();

                return NoContent();
            }
            catch (DbUpdateException)
            {
                return BadRequest("Foreign key constraint violation: Cannot delete this entity due to related records in other tables.");
            }
        }

        private bool LoaiChuongTrinhExists(int id)
        {
            return (context.LoaiChuongTrinhRepository.GetAll()?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
