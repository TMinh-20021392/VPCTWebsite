using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.ExpertModel;
using VPCT.Repositories.Infrastructure;

namespace VPCTWebsiteAPI.Controllers.MainModels.ExpertModel
{
    [Route("api/[controller]")]
    [ApiController]
    public class HocVisController(IUnitOfWork context) : ControllerBase
    {

        // GET: api/HocVis
        [HttpGet]
        public ActionResult<IEnumerable<HocVi>> GetHocVi()
        {
            return context.HocViRepository.GetAll().ToList();
        }

        // GET: api/HocVis/5
        [HttpGet("{id}")]
        public ActionResult<HocVi> GetHocVi(int id)
        {
            var hocVi = context.HocViRepository.Find(id);

            if (hocVi == null)
            {
                return NotFound();
            }

            return hocVi;
        }

        // PUT: api/HocVis/5
        [HttpPut("{id}")]
        public IActionResult PutHocVi(int id, HocVi hocVi)
        {
            if (id != hocVi.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context.HocViRepository.Update(hocVi);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HocViExists(hocVi.Id))
                    {
                        return NotFound();
                    }
                }
                return NoContent();
            }

            return BadRequest(ModelState);
        }

        // POST: api/HocVis
        [HttpPost]
        public ActionResult<HocVi> PostHocVi(HocVi hocVi)
        {
            context.HocViRepository.Create(hocVi);
            context.SaveChanges();

            return CreatedAtAction("GetHocVi", new { id = hocVi.Id }, hocVi);
        }

        // DELETE: api/HocVis/5
        [HttpDelete("{id}")]
        public IActionResult DeleteHocVi(int id)
        {
            var hocVi = context.HocViRepository.Find(id);
            if (hocVi == null)
            {
                return NotFound();
            }

            context.HocViRepository.Delete(hocVi);
            context.SaveChanges();

            return NoContent();
        }

        private bool HocViExists(int id)
        {
            return (context.HocViRepository.GetAll()?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
