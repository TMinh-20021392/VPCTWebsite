using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.ExpertModel;
using VPCT.Repositories.Infrastructure;

namespace VPCTWebsiteAPI.Controllers.MainModels.ExpertModel
{
    [Route("api/[controller]")]
    [ApiController]
    public class GiaiThuongsController(IUnitOfWork context) : ControllerBase
    {

        // GET: api/GiaiThuongs
        [HttpGet]
        public ActionResult<IEnumerable<GiaiThuong>> GetGiaiThuong()
        {
            return context.GiaiThuongRepository.GetAll().ToList();
        }

        // GET: api/GiaiThuongs/5
        [HttpGet("{id}")]
        public ActionResult<GiaiThuong> GetGiaiThuong(int id)
        {
            var giaiThuong = context.GiaiThuongRepository.Find(id);

            if (giaiThuong == null)
            {
                return NotFound();
            }

            return giaiThuong;
        }

        // PUT: api/GiaiThuongs/5
        [HttpPut("{id}")]
        public IActionResult PutGiaiThuong(int id, GiaiThuong giaiThuong)
        {
            if (id != giaiThuong.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context.GiaiThuongRepository.Update(giaiThuong);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GiaiThuongExists(giaiThuong.Id))
                    {
                        return NotFound();
                    }
                }
                return NoContent();
            }

            return BadRequest(ModelState);
        }

        // POST: api/GiaiThuongs
        [HttpPost]
        public ActionResult<GiaiThuong> PostGiaiThuong(GiaiThuong giaiThuong)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.GiaiThuongRepository.Create(giaiThuong);
            context.SaveChanges();

            return CreatedAtAction("GetGiaiThuong", new { id = giaiThuong.Id }, giaiThuong);
        }

        // DELETE: api/GiaiThuongs/5
        [HttpDelete("{id}")]
        public IActionResult DeleteGiaiThuong(int id)
        {
            var giaiThuong = context.GiaiThuongRepository.Find(id);
            if (giaiThuong == null)
            {
                return NotFound();
            }

            context.GiaiThuongRepository.Delete(giaiThuong);
            context.SaveChanges();

            return NoContent();
        }

        private bool GiaiThuongExists(int id)
        {
            return (context.GiaiThuongRepository.GetAll()?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
