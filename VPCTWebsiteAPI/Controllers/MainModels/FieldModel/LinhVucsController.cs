using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.FieldModel;
using VPCT.Repositories.Infrastructure;

namespace VPCTWebsiteAPI.Controllers.MainModels.FieldModel
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinhVucsController(IUnitOfWork context) : ControllerBase
    {

        // GET: api/LinhVucs
        [HttpGet]
        public ActionResult<IEnumerable<LinhVuc>> GetLinhVuc()
        {
            return context.LinhVucRepository.GetAll().ToList();
        }

        // GET: api/LinhVucs/5
        [HttpGet("{id}")]
        public ActionResult<LinhVuc> GetLinhVuc(int id)
        {
            var linhVuc = context.LinhVucRepository.Find(id);

            if (linhVuc == null)
            {
                return NotFound();
            }

            return linhVuc;
        }

        // PUT: api/LinhVucs/5
        [HttpPut("{id}")]
        public IActionResult PutLinhVuc(int id, LinhVuc linhVuc)
        {
            if (id != linhVuc.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context.LinhVucRepository.Update(linhVuc);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LinhVucExists(linhVuc.Id))
                    {
                        return NotFound();
                    }
                }
                return NoContent();
            }

            return BadRequest(ModelState);
        }

        // POST: api/LinhVucs
        [HttpPost]
        public ActionResult<LinhVuc> PostLinhVuc(LinhVuc linhVuc)
        {
            context.LinhVucRepository.Create(linhVuc);
            context.SaveChanges();

            return CreatedAtAction("GetLinhVuc", new { id = linhVuc.Id }, linhVuc);
        }

        // DELETE: api/LinhVucs/5
        [HttpDelete("{id}")]
        public IActionResult DeleteLinhVuc(int id)
        {
            var linhVuc = context.LinhVucRepository.Find(id);
            if (linhVuc == null)
            {
                return NotFound();
            }

            context.LinhVucRepository.Delete(linhVuc);
            context.SaveChanges();

            return NoContent();
        }

        private bool LinhVucExists(int id)
        {
            return (context.LinhVucRepository.GetAll()?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
