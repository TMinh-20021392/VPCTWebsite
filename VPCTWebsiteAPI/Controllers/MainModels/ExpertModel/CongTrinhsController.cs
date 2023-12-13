using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.ExpertModel;
using VPCT.Repositories.Infrastructure;

namespace VPCTWebsiteAPI.Controllers.MainModels.ExpertModel
{
    [Route("api/[controller]")]
    [ApiController]
    public class CongTrinhsController(IUnitOfWork context) : ControllerBase
    {

        // GET: api/CongTrinhs
        [HttpGet]
        public ActionResult<IEnumerable<CongTrinh>> GetCongTrinh()
        {
            return context.CongTrinhRepository.GetAll().ToList();
        }

        // GET: api/CongTrinhs/5
        [HttpGet("{id}")]
        public ActionResult<CongTrinh> GetCongTrinh(int id)
        {
            var congTrinh = context.CongTrinhRepository.Find(id);

            if (congTrinh == null)
            {
                return NotFound();
            }

            return congTrinh;
        }

        // PUT: api/CongTrinhs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public IActionResult PutCongTrinh(int id, CongTrinh congTrinh)
        {
            if (id != congTrinh.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context.CongTrinhRepository.Update(congTrinh);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CongTrinhExists(congTrinh.Id))
                    {
                        return NotFound();
                    }
                }
                return NoContent();
            }

            return BadRequest(ModelState);
        }

        // POST: api/CongTrinhs
        [HttpPost]
        public ActionResult<CongTrinh> PostCongTrinh(CongTrinh congTrinh)
        {
            context.CongTrinhRepository.Create(congTrinh);
            context.SaveChanges();

            return CreatedAtAction("GetCongTrinh", new { id = congTrinh.Id }, congTrinh);
        }

        // DELETE: api/CongTrinhs/5
        [HttpDelete("{id}")]
        public IActionResult DeleteCongTrinh(int id)
        {
            var congTrinh = context.CongTrinhRepository.Find(id);
            if (congTrinh == null)
            {
                return NotFound();
            }

            context.CongTrinhRepository.Delete(congTrinh);
            context.SaveChanges();

            return NoContent();
        }

        private bool CongTrinhExists(int id)
        {
            return (context.CongTrinhRepository.GetAll()?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
