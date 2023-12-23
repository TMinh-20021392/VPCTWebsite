using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.TaskModel;
using VPCT.Repositories.Infrastructure;

namespace VPCTWebsiteAPI.Controllers.MainModels.TaskModel
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhanBoNoiDungsController(IUnitOfWork context) : ControllerBase
    {

        // GET: api/PhanBoNoiDungs
        [HttpGet]
        public ActionResult<IEnumerable<PhanBoNoiDung>> GetPhanBoNoiDung()
        {
            return context.PhanBoNoiDungRepository.GetAll().ToList();
        }

        // GET: api/PhanBoNoiDungs/5
        [HttpGet("{id}")]
        public ActionResult<PhanBoNoiDung> GetPhanBoNoiDung(int id)
        {
            var phanBoNoiDung = context.PhanBoNoiDungRepository.Find(id);

            if (phanBoNoiDung == null)
            {
                return NotFound();
            }

            return phanBoNoiDung;
        }

        // PUT: api/PhanBoNoiDungs/5
        [HttpPut("{id}")]
        public IActionResult PutPhanBoNoiDung(int id, PhanBoNoiDung phanBoNoiDung)
        {
            if (id != phanBoNoiDung.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context.PhanBoNoiDungRepository.Update(phanBoNoiDung);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhanBoNoiDungExists(phanBoNoiDung.Id))
                    {
                        return NotFound();
                    }
                }
                return NoContent();
            }

            return BadRequest(ModelState);
        }

        // POST: api/PhanBoNoiDungs
        [HttpPost]
        public ActionResult<PhanBoNoiDung> PostPhanBoNoiDung(PhanBoNoiDung phanBoNoiDung)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.PhanBoNoiDungRepository.Create(phanBoNoiDung);
            context.SaveChanges();

            return CreatedAtAction("GetPhanBoNoiDung", new { id = phanBoNoiDung.Id }, phanBoNoiDung);
        }

        // DELETE: api/PhanBoNoiDungs/5
        [HttpDelete("{id}")]
        public IActionResult DeletePhanBoNoiDung(int id)
        {
            try
            {
                var phanBoNoiDung = context.PhanBoNoiDungRepository.Find(id);
                if (phanBoNoiDung == null)
                {
                    return NotFound();
                }

                context.PhanBoNoiDungRepository.Delete(phanBoNoiDung);
                context.SaveChanges();

                return NoContent();
            }
            catch (DbUpdateException)
            {
                return BadRequest("Foreign key constraint violation: Cannot delete this entity due to related records in other tables.");
            }
        }

        private bool PhanBoNoiDungExists(int id)
        {
            return (context.PhanBoNoiDungRepository.GetAll()?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
