using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.DepartmentModel;
using VPCT.Repositories.Infrastructure;

namespace VPCTWebsiteAPI.Controllers.MainModels.DepartmentModel
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonViChuQuansController(IUnitOfWork context) : ControllerBase
    {

        // GET: api/DonViChuQuans
        [HttpGet]
        public ActionResult<IEnumerable<DonViChuQuan>> GetDonViChuQuan()
        {
            return context.DonViChuQuanRepository.GetAll().ToList();
        }

        // GET: api/DonViChuQuans/5
        [HttpGet("{id}")]
        public ActionResult<DonViChuQuan> GetDonViChuQuan(int id)
        {
            var donViChuQuan = context.DonViChuQuanRepository.Find(id);

            if (donViChuQuan == null)
            {
                return NotFound();
            }

            return donViChuQuan;
        }

        [HttpGet("{donViChuQuanId}/CoQuanChuTri")]
        [ProducesResponseType(200, Type = typeof(DonViChuQuan))]
        [ProducesResponseType(400)]
        public IActionResult GetCoQuanChuTriByDonViChuQuan(int donViChuQuanId)
        {
            if (!DonViChuQuanExists(donViChuQuanId))
            {
                return NotFound();
            }

            var coQuanChuTri = context.CoQuanChuTriRepository.SearchCoQuanChuTriByDonViChuQuanId(donViChuQuanId).ToList();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(coQuanChuTri);
        }

        // PUT: api/DonViChuQuans/5
        [HttpPut("{id}")]
        public IActionResult PutDonViChuQuan(int id, DonViChuQuan donViChuQuan)
        {
            if (id != donViChuQuan.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context.DonViChuQuanRepository.Update(donViChuQuan);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DonViChuQuanExists(donViChuQuan.Id))
                    {
                        return NotFound();
                    }
                }
                return NoContent();
            }

            return BadRequest(ModelState);
        }

        // POST: api/DonViChuQuans
        [HttpPost]
        public ActionResult<DonViChuQuan> PostDonViChuQuan(DonViChuQuan donViChuQuan)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.DonViChuQuanRepository.Create(donViChuQuan);
            context.SaveChanges();

            return CreatedAtAction("GetDonViChuQuan", new { id = donViChuQuan.Id }, donViChuQuan);
        }

        // DELETE: api/DonViChuQuans/5
        [HttpDelete("{id}")]
        public IActionResult DeleteDonViChuQuan(int id)
        {
            var donViChuQuan = context.DonViChuQuanRepository.Find(id);
            if (donViChuQuan == null)
            {
                return NotFound();
            }

            context.DonViChuQuanRepository.Delete(donViChuQuan);
            context.SaveChanges();

            return NoContent();
        }

        private bool DonViChuQuanExists(int id)
        {
            return (context.DonViChuQuanRepository.GetAll()?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
