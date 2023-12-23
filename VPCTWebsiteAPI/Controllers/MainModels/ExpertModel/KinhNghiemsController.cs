using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.ExpertModel;
using VPCT.Repositories.Infrastructure;

namespace VPCTWebsiteAPI.Controllers.MainModels.ExpertModel
{
    [Route("api/[controller]")]
    [ApiController]
    public class KinhNghiemsController(IUnitOfWork context) : ControllerBase
    {

        // GET: api/KinhNghiems
        [HttpGet]
        public ActionResult<IEnumerable<KinhNghiem>> GetKinhNghiem()
        {
            return context.KinhNghiemRepository.GetAll().ToList();
        }

        // GET: api/KinhNghiems/5
        [HttpGet("{id}")]
        public ActionResult<KinhNghiem> GetKinhNghiem(int id)
        {
            var kinhNghiem = context.KinhNghiemRepository.Find(id);

            if (kinhNghiem == null)
            {
                return NotFound();
            }

            return kinhNghiem;
        }

        // PUT: api/KinhNghiems/5
        [HttpPut("{id}")]
        public IActionResult PutKinhNghiem(int id, KinhNghiem kinhNghiem)
        {
            if (id != kinhNghiem.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context.KinhNghiemRepository.Update(kinhNghiem);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KinhNghiemExists(kinhNghiem.Id))
                    {
                        return NotFound();
                    }
                }
                return NoContent();
            }

            return BadRequest(ModelState);
        }

        // POST: api/KinhNghiems
        [HttpPost]
        public ActionResult<KinhNghiem> PostKinhNghiem(KinhNghiem kinhNghiem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.KinhNghiemRepository.Create(kinhNghiem);
            context.SaveChanges();

            return CreatedAtAction("GetKinhNghiem", new { id = kinhNghiem.Id }, kinhNghiem);
        }

        // DELETE: api/KinhNghiems/5
        [HttpDelete("{id}")]
        public IActionResult DeleteKinhNghiem(int id)
        {
            try
            {
                var kinhNghiem = context.KinhNghiemRepository.Find(id);
                if (kinhNghiem == null)
                {
                    return NotFound();
                }

                context.KinhNghiemRepository.Delete(kinhNghiem);
                context.SaveChanges();

                return NoContent();
            }
            catch (DbUpdateException)
            {
                return BadRequest("Foreign key constraint violation: Cannot delete this entity due to related records in other tables.");
            }
        }

        private bool KinhNghiemExists(int id)
        {
            return (context.KinhNghiemRepository.GetAll()?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
