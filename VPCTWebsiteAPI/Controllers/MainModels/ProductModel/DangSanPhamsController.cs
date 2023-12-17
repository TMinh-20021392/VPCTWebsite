using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.ProductModel;
using VPCT.Repositories.Infrastructure;

namespace VPCTWebsiteAPI.Controllers.MainModels.ProductModel
{
    [Route("api/[controller]")]
    [ApiController]
    public class DangSanPhamsController(IUnitOfWork context) : ControllerBase
    {

        // GET: api/DangSanPhams
        [HttpGet]
        public ActionResult<IEnumerable<DangSanPham>> GetDangSanPham()
        {
            return context.DangSanPhamRepository.GetAll().ToList();
        }

        // GET: api/DangSanPhams/5
        [HttpGet("{id}")]
        public ActionResult<DangSanPham> GetDangSanPham(int id)
        {
            var dangSanPham = context.DangSanPhamRepository.Find(id);

            if (dangSanPham == null)
            {
                return NotFound();
            }

            return dangSanPham;
        }

        // PUT: api/DangSanPhams/5
        [HttpPut("{id}")]
        public IActionResult PutDangSanPham(int id, DangSanPham dangSanPham)
        {
            if (id != dangSanPham.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context.DangSanPhamRepository.Update(dangSanPham);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DangSanPhamExists(dangSanPham.Id))
                    {
                        return NotFound();
                    }
                }
                return NoContent();
            }

            return BadRequest(ModelState);
        }

        // POST: api/DangSanPhams
        [HttpPost]
        public ActionResult<DangSanPham> PostDangSanPham(DangSanPham dangSanPham)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.DangSanPhamRepository.Create(dangSanPham);
            context.SaveChanges();

            return CreatedAtAction("GetDangSanPham", new { id = dangSanPham.Id }, dangSanPham);
        }

        // DELETE: api/DangSanPhams/5
        [HttpDelete("{id}")]
        public IActionResult DeleteDangSanPham(int id)
        {
            var dangSanPham = context.DangSanPhamRepository.Find(id);
            if (dangSanPham == null)
            {
                return NotFound();
            }

            context.DangSanPhamRepository.Delete(dangSanPham);
            context.SaveChanges();

            return NoContent();
        }

        private bool DangSanPhamExists(int id)
        {
            return (context.DangSanPhamRepository.GetAll()?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
