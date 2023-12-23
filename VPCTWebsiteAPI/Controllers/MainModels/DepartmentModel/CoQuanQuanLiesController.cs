using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.DepartmentModel;
using VPCT.Repositories.Infrastructure;
using static VPCT.Core.Models.MainModels.DepartmentModel.CoQuanQuanLy;

namespace VPCTWebsiteAPI.Controllers.MainModels.DepartmentModel
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoQuanQuanLiesController(IUnitOfWork context) : ControllerBase
    {

        // GET: api/CoQuanQuanLies
        [HttpGet]
        public ActionResult<IEnumerable<CoQuanQuanLy>> GetCoQuanQuanLy()
        {
            return context.CoQuanQuanLyRepository.GetAll().ToList();
        }

        // GET: api/CoQuanQuanLies/5
        [HttpGet("{id}")]
        public ActionResult<CoQuanQuanLy> GetCoQuanQuanLy(int id)
        {
            var coQuanQuanLy = context.CoQuanQuanLyRepository.Find(id);

            if (coQuanQuanLy == null)
            {
                return NotFound();
            }

            return coQuanQuanLy;
        }

        [HttpGet("GetCoQuanQuanLyByLoai/{loaiQuanLy}")]
        public ActionResult<IEnumerable<CoQuanQuanLy>> GetCoQuanQuanLyByLoai(LoaiQuanLy loaiQuanLy)
        {
            var coQuanQuanLy = context.CoQuanQuanLyRepository.SearchCoQuanQuanLyByLoaiQuanLy(loaiQuanLy).ToList();

            if (coQuanQuanLy.Count == 0)
            {
                return NotFound();
            }

            return coQuanQuanLy;
        }

        // PUT: api/CoQuanQuanLies/5
        [HttpPut("{id}")]
        public IActionResult PutCoQuanQuanLy(int id, CoQuanQuanLy coQuanQuanLy)
        {
            if (id != coQuanQuanLy.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context.CoQuanQuanLyRepository.Update(coQuanQuanLy);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CoQuanQuanLyExists(coQuanQuanLy.Id))
                    {
                        return NotFound();
                    }
                }
                return NoContent();
            }

            return BadRequest(ModelState);
        }

        // POST: api/CoQuanQuanLies
        [HttpPost]
        public ActionResult<CoQuanQuanLy> PostCoQuanQuanLy(CoQuanQuanLy coQuanQuanLy)
        {
            context.CoQuanQuanLyRepository.Create(coQuanQuanLy);
            context.SaveChanges();

            return CreatedAtAction("GetCoQuanQuanLy", new { id = coQuanQuanLy.Id }, coQuanQuanLy);
        }

        // DELETE: api/CoQuanQuanLies/5
        [HttpDelete("{id}")]
        public IActionResult DeleteCoQuanQuanLy(int id)
        {
            try
            {
                var coQuanQuanLy = context.CoQuanQuanLyRepository.Find(id);
                if (coQuanQuanLy == null)
                {
                    return NotFound();
                }

                context.CoQuanQuanLyRepository.Delete(coQuanQuanLy);
                context.SaveChanges();

                return NoContent();
            }
            catch (DbUpdateException)
            {
                return BadRequest("Foreign key constraint violation: Cannot delete this entity due to related records in other tables.");
            }
        }

        private bool CoQuanQuanLyExists(int id)
        {
            return (context.CoQuanQuanLyRepository.GetAll()?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
