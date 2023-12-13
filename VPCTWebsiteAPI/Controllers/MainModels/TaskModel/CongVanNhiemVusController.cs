using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.TaskModel;
using VPCT.Repositories.Infrastructure;

namespace VPCTWebsiteAPI.Controllers.MainModels.TaskModel
{
    [Route("api/[controller]")]
    [ApiController]
    public class CongVanNhiemVusController(IUnitOfWork context) : ControllerBase
    {

        // GET: api/CongVanNhiemVus
        [HttpGet]
        public ActionResult<IEnumerable<CongVanNhiemVu>> GetCongVanNhiemVu()
        {
            return context.CongVanNhiemVuRepository.GetAll().ToList();
        }

        // GET: api/CongVanNhiemVus/5
        [HttpGet("{id}")]
        public ActionResult<CongVanNhiemVu> GetCongVanNhiemVu(int id)
        {
            var congVanNhiemVu = context.CongVanNhiemVuRepository.Find(id);

            if (congVanNhiemVu == null)
            {
                return NotFound();
            }

            return congVanNhiemVu;
        }

        // PUT: api/CongVanNhiemVus/5
        [HttpPut("{id}")]
        public IActionResult PutCongVanNhiemVu(int id, CongVanNhiemVu congVanNhiemVu)
        {
            if (id != congVanNhiemVu.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context.CongVanNhiemVuRepository.Update(congVanNhiemVu);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CongVanNhiemVuExists(congVanNhiemVu.Id))
                    {
                        return NotFound();
                    }
                }
                return NoContent();
            }

            return BadRequest(ModelState);
        }

        // POST: api/CongVanNhiemVus
        [HttpPost]
        public ActionResult<CongVanNhiemVu> PostCongVanNhiemVu(CongVanNhiemVu congVanNhiemVu)
        {
            context.CongVanNhiemVuRepository.Create(congVanNhiemVu);
            context.SaveChanges();

            return CreatedAtAction("GetCongVanNhiemVu", new { id = congVanNhiemVu.Id }, congVanNhiemVu);
        }

        // DELETE: api/CongVanNhiemVus/5
        [HttpDelete("{id}")]
        public IActionResult DeleteCongVanNhiemVu(int id)
        {
            var congVanNhiemVu = context.CongVanNhiemVuRepository.Find(id);
            if (congVanNhiemVu == null)
            {
                return NotFound();
            }

            context.CongVanNhiemVuRepository.Delete(congVanNhiemVu);
            context.SaveChanges();

            return NoContent();
        }

        private bool CongVanNhiemVuExists(int id)
        {
            return (context.CongVanNhiemVuRepository.GetAll()?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
