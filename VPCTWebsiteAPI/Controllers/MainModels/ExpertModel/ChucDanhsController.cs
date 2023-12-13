using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.ExpertModel;
using VPCT.Repositories.Infrastructure;

namespace VPCTWebsiteAPI.Controllers.MainModels.ExpertModel
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChucDanhsController(IUnitOfWork context) : ControllerBase
    {

        // GET: api/ChucDanhs
        [HttpGet]
        public ActionResult<IEnumerable<ChucDanh>> GetChucDanh()
        {
            return context.ChucDanhRepository.GetAll().ToList();
        }

        // GET: api/ChucDanhs/5
        [HttpGet("{id}")]
        public ActionResult<ChucDanh> GetChucDanh(int id)
        {
            var chucDanh = context.ChucDanhRepository.Find(id);

            if (chucDanh == null)
            {
                return NotFound();
            }

            return chucDanh;
        }

        // PUT: api/ChucDanhs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public IActionResult PutChucDanh(int id, ChucDanh chucDanh)
        {
            if (id != chucDanh.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context.ChucDanhRepository.Update(chucDanh);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChucDanhExists(chucDanh.Id))
                    {
                        return NotFound();
                    }
                }
                return NoContent();
            }
            return BadRequest(ModelState);
        }

        // POST: api/ChucDanhs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public ActionResult<ChucDanh> PostChucDanh(ChucDanh chucDanh)
        {
            context.ChucDanhRepository.Create(chucDanh);
            context.SaveChanges();

            return CreatedAtAction("GetChucDanh", new { id = chucDanh.Id }, chucDanh);
        }

        // DELETE: api/ChucDanhs/5
        [HttpDelete("{id}")]
        public IActionResult DeleteChucDanh(int id)
        {
            var chucDanh = context.ChucDanhRepository.Find(id);
            if (chucDanh == null)
            {
                return NotFound();
            }

            context.ChucDanhRepository.Delete(chucDanh);
            context.SaveChanges();

            return NoContent();
        }

        private bool ChucDanhExists(int id)
        {
            return (context.ChucDanhRepository.GetAll()?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
