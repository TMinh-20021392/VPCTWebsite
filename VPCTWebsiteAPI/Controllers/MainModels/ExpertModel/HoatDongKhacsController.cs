using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.ExpertModel;
using VPCT.Repositories.Infrastructure;

namespace VPCTWebsiteAPI.Controllers.MainModels.ExpertModel
{
    [Route("api/[controller]")]
    [ApiController]
    public class HoatDongKhacsController(IUnitOfWork context) : ControllerBase
    {

        // GET: api/HoatDongKhacs
        [HttpGet]
        public ActionResult<IEnumerable<HoatDongKhac>> GetHoatDongKhac()
        {
            return context.HoatDongKhacRepository.GetAll().ToList();
        }

        // GET: api/HoatDongKhacs/5
        [HttpGet("{id}")]
        public ActionResult<HoatDongKhac> GetHoatDongKhac(int id)
        {
            var hoatDongKhac = context.HoatDongKhacRepository.Find(id);

            if (hoatDongKhac == null)
            {
                return NotFound();
            }

            return hoatDongKhac;
        }

        // PUT: api/HoatDongKhacs/5
        [HttpPut("{id}")]
        public IActionResult PutHoatDongKhac(int id, HoatDongKhac hoatDongKhac)
        {
            if (id != hoatDongKhac.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context.HoatDongKhacRepository.Update(hoatDongKhac);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HoatDongKhacExists(hoatDongKhac.Id))
                    {
                        return NotFound();
                    }
                }
                return NoContent();
            }

            return BadRequest(ModelState);
        }

        // POST: api/HoatDongKhacs
        [HttpPost]
        public ActionResult<HoatDongKhac> PostHoatDongKhac(HoatDongKhac hoatDongKhac)
        {
            context.HoatDongKhacRepository.Create(hoatDongKhac);
            context.SaveChanges();

            return CreatedAtAction("GetHoatDongKhac", new { id = hoatDongKhac.Id }, hoatDongKhac);
        }

        // DELETE: api/HoatDongKhacs/5
        [HttpDelete("{id}")]
        public IActionResult DeleteHoatDongKhac(int id)
        {
            var hoatDongKhac = context.HoatDongKhacRepository.Find(id);
            if (hoatDongKhac == null)
            {
                return NotFound();
            }

            context.HoatDongKhacRepository.Delete(hoatDongKhac);
            context.SaveChanges();

            return NoContent();
        }

        private bool HoatDongKhacExists(int id)
        {
            return (context.HoatDongKhacRepository.GetAll()?.Any(e => e.Id == id)).GetValueOrDefault();

        }
    }
}
