using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.ExpertModel;
using VPCT.Repositories.Infrastructure;

namespace VPCTWebsiteAPI.Controllers.MainModels.ExpertModel
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChucVusController(IUnitOfWork context) : ControllerBase
    {

        // GET: api/ChucVus
        [HttpGet]
        public ActionResult<IEnumerable<ChucVu>> GetChucVu()
        {
            return context.ChucVuRepository.GetAll().ToList();
        }

        // GET: api/ChucVus/5
        [HttpGet("{id}")]
        public ActionResult<ChucVu> GetChucVu(int id)
        {
            var chucVu = context.ChucVuRepository.Find(id);

            if (chucVu == null)
            {
                return NotFound();
            }

            return chucVu;
        }

        // PUT: api/ChucVus/5
        [HttpPut("{id}")]
        public IActionResult PutChucVu(int id, ChucVu chucVu)
        {
            if (id != chucVu.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context.ChucVuRepository.Update(chucVu);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChucVuExists(chucVu.Id))
                    {
                        return NotFound();
                    }
                }
                return NoContent();
            }

            return BadRequest(ModelState);
        }

        // POST: api/ChucVus
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public ActionResult<ChucVu> PostChucVu(ChucVu chucVu)
        {
            context.ChucVuRepository.Create(chucVu);
            context.SaveChanges();

            return CreatedAtAction("GetChucVu", new { id = chucVu.Id }, chucVu);
        }

        // DELETE: api/ChucVus/5
        [HttpDelete("{id}")]
        public IActionResult DeleteChucVu(int id)
        {
            var chucVu = context.ChucVuRepository.Find(id);
            if (chucVu == null)
            {
                return NotFound();
            }

            context.ChucVuRepository.Delete(chucVu);
            context.SaveChanges();

            return NoContent();
        }

        private bool ChucVuExists(int id)
        {
            return (context.ChucVuRepository.GetAll()?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
