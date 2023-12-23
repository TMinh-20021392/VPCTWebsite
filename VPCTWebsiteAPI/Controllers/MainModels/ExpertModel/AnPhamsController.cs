using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.ExpertModel;
using VPCT.Repositories.Infrastructure;

namespace VPCTWebsiteAPI.Controllers.MainModels.ExpertModel
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnPhamsController(IUnitOfWork context) : ControllerBase
    {

        // GET: api/AnPhams
        [HttpGet]
        public ActionResult<IEnumerable<AnPham>> GetAnPham()
        {
            return context.AnPhamRepository.GetAll().ToList();
        }

        // GET: api/AnPhams/5
        [HttpGet("{id}")]
        public ActionResult<AnPham> GetAnPham(int id)
        {
            var anPham = context.AnPhamRepository.Find(id);

            if (anPham == null)
            {
                return NotFound();
            }

            return anPham;
        }

        // PUT: api/AnPhams/5
        [HttpPut("{id}")]
        public IActionResult PutAnPham(int id, AnPham anPham)
        {
            if (id != anPham.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context.AnPhamRepository.Update(anPham);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AnPhamExists(anPham.Id))
                    {
                        return NotFound();
                    }
                }
                return NoContent();
            }

            return BadRequest(ModelState);
        }

        // POST: api/AnPhams
        [HttpPost]
        public ActionResult<AnPham> PostAnPham(AnPham anPham)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.AnPhamRepository.Create(anPham);
            context.SaveChanges();

            return CreatedAtAction("GetAnPham", new { id = anPham.Id }, anPham);
        }

        // DELETE: api/AnPhams/5
        [HttpDelete("{id}")]
        public IActionResult DeleteAnPham(int id)
        {
            try
            {
                var anPham = context.AnPhamRepository.Find(id);
                if (anPham == null)
                {
                    return NotFound();
                }

                context.AnPhamRepository.Delete(anPham);
                context.SaveChanges();

                return NoContent();
            }
            catch (DbUpdateException)
            {
                return BadRequest("Foreign key constraint violation: Cannot delete this entity due to related records in other tables.");
            }
        }

        private bool AnPhamExists(int id)
        {
            return (context.AnPhamRepository.GetAll()?.Any(e => e.Id == id)).GetValueOrDefault();

        }
    }
}
