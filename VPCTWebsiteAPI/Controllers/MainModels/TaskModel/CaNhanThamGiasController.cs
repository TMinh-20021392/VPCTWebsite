using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.TaskModel;
using VPCT.Repositories.Infrastructure;

namespace VPCTWebsiteAPI.Controllers.MainModels.TaskModel
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaNhanThamGiasController(IUnitOfWork context) : ControllerBase
    {

        // GET: api/CaNhanThamGias
        [HttpGet]
        public ActionResult<IEnumerable<CaNhanThamGia>> GetCaNhanThamGia()
        {
            return context.CaNhanThamGiaRepository.GetAll().ToList();
        }

        // GET: api/CaNhanThamGias/5
        [HttpGet("{id}")]
        public ActionResult<CaNhanThamGia> GetCaNhanThamGia(int id)
        {
            var caNhanThamGia = context.CaNhanThamGiaRepository.Find(id);

            if (caNhanThamGia == null)
            {
                return NotFound();
            }

            return caNhanThamGia;
        }

        // PUT: api/CaNhanThamGias/5
        [HttpPut("{id}")]
        public IActionResult PutCaNhanThamGia(int id, CaNhanThamGia caNhanThamGia)
        {
            if (id != caNhanThamGia.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context.CaNhanThamGiaRepository.Update(caNhanThamGia);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CaNhanThamGiaExists(caNhanThamGia.Id))
                    {
                        return NotFound();
                    }
                }
                return NoContent();
            }

            return BadRequest(ModelState);
        }

        // POST: api/CaNhanThamGias
        [HttpPost]
        public ActionResult<CaNhanThamGia> PostCaNhanThamGia(CaNhanThamGia caNhanThamGia)
        {
            context.CaNhanThamGiaRepository.Create(caNhanThamGia);
            context.SaveChanges();

            return CreatedAtAction("GetCaNhanThamGia", new { id = caNhanThamGia.Id }, caNhanThamGia);
        }

        // DELETE: api/CaNhanThamGias/5
        [HttpDelete("{id}")]
        public IActionResult DeleteCaNhanThamGia(int id)
        {
            var caNhanThamGia = context.CaNhanThamGiaRepository.Find(id);
            if (caNhanThamGia == null)
            {
                return NotFound();
            }

            context.CaNhanThamGiaRepository.Delete(caNhanThamGia);
            context.SaveChanges();

            return NoContent();
        }

        private bool CaNhanThamGiaExists(int id)
        {
            return (context.CaNhanThamGiaRepository.GetAll()?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
