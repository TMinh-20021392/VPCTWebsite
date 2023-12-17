using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.ProductModel;
using VPCT.Repositories.Infrastructure;

namespace VPCTWebsiteAPI.Controllers.MainModels.ProductModel
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoaiSanPhamsController(IUnitOfWork context) : ControllerBase
    {

        // GET: api/LoaiSanPhams
        [HttpGet]
        public ActionResult<IEnumerable<LoaiSanPham>> GetLoaiSanPham()
        {
            return context.LoaiSanPhamRepository.GetAll().Include(x => x.DangSanPham).ToList();
        }

        // GET: api/LoaiSanPhams/5
        [HttpGet("{id}")]
        public ActionResult<LoaiSanPham> GetLoaiSanPham(int id)
        {
            var loaiSanPham = context.LoaiSanPhamRepository.GetAll().Include(x => x.DangSanPham).FirstOrDefault(x => x.Id == id);

            if (loaiSanPham == null)
            {
                return NotFound();
            }

            return loaiSanPham;
        }

        [HttpGet("GetLoaiSanPhamByDangSanPham/{dangId}")]
        public ActionResult<IEnumerable<LoaiSanPham>> GetLoaiSanPhamByDangSanPham(int dangId)
        {
            var l = context.LoaiSanPhamRepository.SearchLoaiSanPhamByDangSanPhamId(dangId).Include(x => x.DangSanPham).ToList();

            if (l.Count == 0)
            {
                return NotFound();
            }

            return l;
        }

        // PUT: api/LoaiSanPhams/5
        [HttpPut("{id}")]
        public IActionResult PutLoaiSanPham(int id, LoaiSanPham loaiSanPham)
        {
            if (id != loaiSanPham.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context.LoaiSanPhamRepository.Update(loaiSanPham);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoaiSanPhamExists(loaiSanPham.Id))
                    {
                        return NotFound();
                    }
                }
                return NoContent();
            }

            return BadRequest(ModelState);
        }

        // POST: api/LoaiSanPhams
        [HttpPost]
        public ActionResult<LoaiSanPham> PostLoaiSanPham(LoaiSanPham loaiSanPham)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.LoaiSanPhamRepository.Create(loaiSanPham);
            context.SaveChanges();

            return CreatedAtAction("GetLoaiSanPham", new { id = loaiSanPham.Id }, loaiSanPham);
        }

        // DELETE: api/LoaiSanPhams/5
        [HttpDelete("{id}")]
        public IActionResult DeleteLoaiSanPham(int id)
        {
            var loaiSanPham = context.LoaiSanPhamRepository.Find(id);
            if (loaiSanPham == null)
            {
                return NotFound();
            }

            context.LoaiSanPhamRepository.Delete(loaiSanPham);
            context.SaveChanges();

            return NoContent();
        }

        private bool LoaiSanPhamExists(int id)
        {
            return (context.LoaiSanPhamRepository.GetAll()?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
