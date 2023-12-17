using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models;
using VPCT.Repositories.Infrastructure;

namespace VPCTWebsiteAPI.Controllers.MainModels
{
    [Route("api/[controller]")]
    [ApiController]
    public class GiaiDoansController(IUnitOfWork context) : ControllerBase
    {

        // GET: api/GiaiDoans
        [HttpGet]
        public ActionResult<IEnumerable<GiaiDoan>> GetGiaiDoan()
        {
            return context.GiaiDoanRepository.GetAll().ToList();
        }

        // GET: api/GiaiDoans/5
        [HttpGet("{id}")]
        public ActionResult<GiaiDoan> GetGiaiDoan(int id)
        {
            var giaiDoan = context.GiaiDoanRepository.Find(id);

            if (giaiDoan == null)
            {
                return NotFound();
            }

            return giaiDoan;
        }

        // PUT: api/GiaiDoans/5
        [HttpPut("{id}")]
        public IActionResult PutGiaiDoan(int id, GiaiDoan giaiDoan)
        {
            if (id != giaiDoan.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context.GiaiDoanRepository.Update(giaiDoan);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GiaiDoanExists(giaiDoan.Id))
                    {
                        return NotFound();
                    }
                }
                return NoContent();
            }

            return BadRequest(ModelState);
        }

        // POST: api/GiaiDoans
        [HttpPost]
        public ActionResult<GiaiDoan> PostGiaiDoan(GiaiDoan giaiDoan)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.GiaiDoanRepository.Create(giaiDoan);
            context.SaveChanges();

            return CreatedAtAction("GetGiaiDoan", new { id = giaiDoan.Id }, giaiDoan);
        }

        // DELETE: api/GiaiDoans/5
        [HttpDelete("{id}")]
        public IActionResult DeleteGiaiDoan(int id)
        {
            var giaiDoan = context.GiaiDoanRepository.Find(id);
            if (giaiDoan == null)
            {
                return NotFound();
            }

            context.GiaiDoanRepository.Delete(giaiDoan);
            context.SaveChanges();

            return NoContent();
        }

        private bool GiaiDoanExists(int id)
        {
            return (context.GiaiDoanRepository.GetAll()?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
