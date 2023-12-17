using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.ExpertModel;
using VPCT.Repositories.Infrastructure;

namespace VPCTWebsiteAPI.Controllers.MainModels.ExpertModel
{
    [Route("api/[controller]")]
    [ApiController]
    public class HocHamsController(IUnitOfWork context) : ControllerBase
    {

        // GET: api/HocHams
        [HttpGet]
        public ActionResult<IEnumerable<HocHam>> GetHocHam()
        {
            return context.HocHamRepository.GetAll().ToList();
        }

        // GET: api/HocHams/5
        [HttpGet("{id}")]
        public ActionResult<HocHam> GetHocHam(int id)
        {
            var hocHam = context.HocHamRepository.Find(id);

            if (hocHam == null)
            {
                return NotFound();
            }

            return hocHam;
        }

        // PUT: api/HocHams/5
        [HttpPut("{id}")]
        public IActionResult PutHocHam(int id, HocHam hocHam)
        {
            if (id != hocHam.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context.HocHamRepository.Update(hocHam);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HocHamExists(hocHam.Id))
                    {
                        return NotFound();
                    }
                }
                return NoContent();
            }

            return BadRequest(ModelState);
        }

        // POST: api/HocHams
        [HttpPost]
        public ActionResult<HocHam> PostHocHam(HocHam hocHam)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.HocHamRepository.Create(hocHam);
            context.SaveChanges();

            return CreatedAtAction("GetHocHam", new { id = hocHam.Id }, hocHam);
        }

        // DELETE: api/HocHams/5
        [HttpDelete("{id}")]
        public IActionResult DeleteHocHam(int id)
        {
            var hocHam = context.HocHamRepository.Find(id);
            if (hocHam == null)
            {
                return NotFound();
            }

            context.HocHamRepository.Delete(hocHam);
            context.SaveChanges();

            return NoContent();
        }

        private bool HocHamExists(int id)
        {
            return (context.HocHamRepository.GetAll()?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
