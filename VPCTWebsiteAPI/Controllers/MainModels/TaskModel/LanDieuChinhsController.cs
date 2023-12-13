using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.TaskModel;
using VPCT.Repositories.Infrastructure;

namespace VPCTWebsiteAPI.Controllers.MainModels.TaskModel
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanDieuChinhsController(IUnitOfWork context) : ControllerBase
    {

        // GET: api/LanDieuChinhs
        [HttpGet]
        public ActionResult<IEnumerable<LanDieuChinh>> GetLanDieuChinh()
        {
            return context.LanDieuChinhRepository.GetAll().ToList();
        }

        // GET: api/LanDieuChinhs/5
        [HttpGet("{id}")]
        public ActionResult<LanDieuChinh> GetLanDieuChinh(int id)
        {
            var lanDieuChinh = context.LanDieuChinhRepository.Find(id);

            if (lanDieuChinh == null)
            {
                return NotFound();
            }

            return lanDieuChinh;
        }

        // PUT: api/LanDieuChinhs/5
        [HttpPut("{id}")]
        public IActionResult PutLanDieuChinh(int id, LanDieuChinh lanDieuChinh)
        {
            if (id != lanDieuChinh.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context.LanDieuChinhRepository.Update(lanDieuChinh);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LanDieuChinhExists(lanDieuChinh.Id))
                    {
                        return NotFound();
                    }
                }
                return NoContent();
            }

            return BadRequest(ModelState);
        }

        // POST: api/LanDieuChinhs
        [HttpPost]
        public ActionResult<LanDieuChinh> PostLanDieuChinh(LanDieuChinh lanDieuChinh)
        {
            context.LanDieuChinhRepository.Create(lanDieuChinh);
            context.SaveChanges();

            return CreatedAtAction("GetLanDieuChinh", new { id = lanDieuChinh.Id }, lanDieuChinh);
        }

        // DELETE: api/LanDieuChinhs/5
        [HttpDelete("{id}")]
        public IActionResult DeleteLanDieuChinh(int id)
        {
            var lanDieuChinh = context.LanDieuChinhRepository.Find(id);
            if (lanDieuChinh == null)
            {
                return NotFound();
            }

            context.LanDieuChinhRepository.Delete(lanDieuChinh);
            context.SaveChanges();

            return NoContent();
        }

        private bool LanDieuChinhExists(int id)
        {
            return (context.LanDieuChinhRepository.GetAll()?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
