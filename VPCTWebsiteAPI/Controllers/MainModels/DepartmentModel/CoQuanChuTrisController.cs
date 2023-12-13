using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.DepartmentModel;
using VPCT.Repositories.Infrastructure;

namespace VPCTWebsiteAPI.Controllers.MainModels.DepartmentModel
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoQuanChuTrisController(IUnitOfWork context) : ControllerBase
    {

        // GET: api/CoQuanChuTris
        [HttpGet]
        public ActionResult<IEnumerable<CoQuanChuTri>> GetCoQuanChuTri()
        {
            return context.CoQuanChuTriRepository.GetAll().ToList();
        }

        // GET: api/CoQuanChuTris/5
        [HttpGet("{id}")]
        public ActionResult<CoQuanChuTri> GetCoQuanChuTri(int id)
        {
            var coQuanChuTri = context.CoQuanChuTriRepository.Find(id);

            if (coQuanChuTri == null)
            {
                return NotFound();
            }

            return coQuanChuTri;
        }

        // PUT: api/CoQuanChuTris/5
        [HttpPut("{id}")]
        public IActionResult PutCoQuanChuTri(int id, CoQuanChuTri coQuanChuTri)
        {
            if (id != coQuanChuTri.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context.CoQuanChuTriRepository.Update(coQuanChuTri);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CoQuanChuTriExists(coQuanChuTri.Id))
                    {
                        return NotFound();
                    }
                }
                return NoContent();
            }

            return BadRequest(ModelState);
        }

        // POST: api/CoQuanChuTris
        [HttpPost]
        public ActionResult<CoQuanChuTri> PostCoQuanChuTri(CoQuanChuTri coQuanChuTri)
        {
            context.CoQuanChuTriRepository.Create(coQuanChuTri);
            context.SaveChanges();

            return CreatedAtAction("GetCoQuanChuTri", new { id = coQuanChuTri.Id }, coQuanChuTri);
        }

        // DELETE: api/CoQuanChuTris/5
        [HttpDelete("{id}")]
        public IActionResult DeleteCoQuanChuTri(int id)
        {
            var coQuanChuTri = context.CoQuanChuTriRepository.Find(id);
            if (coQuanChuTri == null)
            {
                return NotFound();
            }

            context.CoQuanChuTriRepository.Delete(coQuanChuTri);
            context.SaveChanges();

            return NoContent();
        }

        private bool CoQuanChuTriExists(int id)
        {
            return (context.CoQuanChuTriRepository.GetAll()?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
