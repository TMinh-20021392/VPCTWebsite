using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.ExpertModel;
using VPCT.Repositories.Infrastructure;

namespace VPCTWebsiteAPI.Controllers.MainModels.ExpertModel
{
    [Route("api/[controller]")]
    [ApiController]
    public class VanBangsController(IUnitOfWork context) : ControllerBase
    {

        // GET: api/VanBangs
        [HttpGet]
        public ActionResult<IEnumerable<VanBang>> GetVanBang()
        {
            return context.VanBangRepository.GetAll().ToList();
        }

        // GET: api/VanBangs/5
        [HttpGet("{id}")]
        public ActionResult<VanBang> GetVanBang(int id)
        {
            var vanBang = context.VanBangRepository.Find(id);

            if (vanBang == null)
            {
                return NotFound();
            }

            return vanBang;
        }

        // PUT: api/VanBangs/5
        [HttpPut("{id}")]
        public IActionResult PutVanBang(int id, VanBang vanBang)
        {
            if (id != vanBang.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context.VanBangRepository.Update(vanBang);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VanBangExists(vanBang.Id))
                    {
                        return NotFound();
                    }
                }
                return NoContent();
            }

            return BadRequest(ModelState);
        }

        // POST: api/VanBangs
        [HttpPost]
        public ActionResult<VanBang> PostVanBang(VanBang vanBang)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.VanBangRepository.Create(vanBang);
            context.SaveChanges();

            return CreatedAtAction("GetVanBang", new { id = vanBang.Id }, vanBang);
        }

        // DELETE: api/VanBangs/5
        [HttpDelete("{id}")]
        public IActionResult DeleteVanBang(int id)
        {
            var vanBang = context.VanBangRepository.Find(id);
            if (vanBang == null)
            {
                return NotFound();
            }

            context.VanBangRepository.Delete(vanBang);
            context.SaveChanges();

            return NoContent();
        }

        private bool VanBangExists(int id)
        {
            return (context.VanBangRepository.GetAll()?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
