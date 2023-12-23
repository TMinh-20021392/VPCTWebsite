using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.TaskModel;
using VPCT.Repositories.Infrastructure;

namespace VPCTWebsiteAPI.Controllers.MainModels.TaskModel
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanKiemTrasController(IUnitOfWork context) : ControllerBase
    {

        // GET: api/LanKiemTras
        [HttpGet]
        public ActionResult<IEnumerable<LanKiemTra>> GetLanKiemTra()
        {
            return context.LanKiemTraRepository.GetAll().ToList();
        }

        // GET: api/LanKiemTras/5
        [HttpGet("{id}")]
        public ActionResult<LanKiemTra> GetLanKiemTra(int id)
        {
            var lanKiemTra = context.LanKiemTraRepository.Find(id);

            if (lanKiemTra == null)
            {
                return NotFound();
            }

            return lanKiemTra;
        }

        // PUT: api/LanKiemTras/5
        [HttpPut("{id}")]
        public IActionResult PutLanKiemTra(int id, LanKiemTra lanKiemTra)
        {
            if (id != lanKiemTra.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context.LanKiemTraRepository.Update(lanKiemTra);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LanKiemTraExists(lanKiemTra.Id))
                    {
                        return NotFound();
                    }
                }
                return NoContent();
            }

            return BadRequest(ModelState);
        }

        // POST: api/LanKiemTras
        [HttpPost]
        public ActionResult<LanKiemTra> PostLanKiemTra(LanKiemTra lanKiemTra)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.LanKiemTraRepository.Create(lanKiemTra);
            context.SaveChanges();

            return CreatedAtAction("GetLanKiemTra", new { id = lanKiemTra.Id }, lanKiemTra);
        }

        // DELETE: api/LanKiemTras/5
        [HttpDelete("{id}")]
        public IActionResult DeleteLanKiemTra(int id)
        {
            try
            {
                var lanKiemTra = context.LanKiemTraRepository.Find(id);
                if (lanKiemTra == null)
                {
                    return NotFound();
                }

                context.LanKiemTraRepository.Delete(lanKiemTra);
                context.SaveChanges();

                return NoContent();
            }
            catch (DbUpdateException)
            {
                return BadRequest("Foreign key constraint violation: Cannot delete this entity due to related records in other tables.");
            }
        }

        private bool LanKiemTraExists(int id)
        {
            return (context.LanKiemTraRepository.GetAll()?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
