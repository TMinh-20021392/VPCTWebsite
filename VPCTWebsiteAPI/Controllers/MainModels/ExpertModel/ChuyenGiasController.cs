using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.ExpertModel;
using VPCT.Repositories.Infrastructure;
using VPCTWebsiteAPI.Service;

namespace VPCTWebsiteAPI.Controllers.MainModels.ExpertModel
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChuyenGiasController(IUnitOfWork context, IImageService imageService) : ControllerBase
    {

        // GET: api/ChuyenGias
        [HttpGet]
        public ActionResult<IEnumerable<ChuyenGia>> GetChuyenGia()
        {
            return context.ChuyenGiaRepository.GetAll()
                .Include(x => x.ChucDanh)
                .Include(x => x.HocVi)
                .Include(x => x.HocHam)
                .Include(x => x.ChucVu).Include(x => x.ChuyenNganh)
                .Include(x => x.CoQuanChuTri)
                .Include(x => x.DonViChuQuan)
                .Include(x => x.LinhVuc)
                .ToList();
        }

        // GET: api/ChuyenGias/5
        [HttpGet("{id}")]
        public ActionResult<ChuyenGia> GetChuyenGia(int id)
        {
            var chuyenGia = context.ChuyenGiaRepository.GetAll()
                .Include(x => x.ChucDanh)
                .Include(x => x.HocVi)
                .Include(x => x.HocHam)
                .Include(x => x.ChucVu).Include(x => x.ChuyenNganh)
                .Include(x => x.CoQuanChuTri)
                .Include(x => x.DonViChuQuan)
                .Include(x => x.LinhVuc).FirstOrDefault(x => x.Id == id);

            if (chuyenGia == null)
            {
                return NotFound();
            }
            chuyenGia.ImageSrc = $"{Request.Scheme}://{Request.Host}{Request.PathBase}/Images/{chuyenGia.ImageName}";
            return chuyenGia;
        }

        [HttpGet("SearchChuyenGia")]
        public ActionResult<IEnumerable<ChuyenGia>> SearchChuyenGia(int? categoryId = null, int? programId = null, int? period = null)
        {
            var chuyenGiaList = context.ChuyenGiaRepository.SearchChuyenGia(categoryId, programId, period)
                .Include(x => x.ChucDanh)
                .Include(x => x.HocVi)
                .Include(x => x.HocHam)
                .Include(x => x.ChucVu).Include(x => x.ChuyenNganh)
                .Include(x => x.CoQuanChuTri)
                .Include(x => x.DonViChuQuan)
                .Include(x => x.LinhVuc).ToList();

            if (chuyenGiaList.Count == 0)
            {
                return NotFound();
            }

            return chuyenGiaList;
        }

        [HttpGet("GetAnPhamByChuyenGia/{chuyenGiaId}")]
        public ActionResult<IEnumerable<AnPham>> GetAnPhamByChuyenGia(int chuyenGiaId)
        {
            var l = context.AnPhamRepository.SearchAnPhamByChuyenGiaId(chuyenGiaId).ToList();

            if (l.Count == 0)
            {
                return NotFound();
            }

            return l;
        }

        [HttpGet("GetCongTrinhByChuyenGia/{chuyenGiaId}")]
        public ActionResult<IEnumerable<CongTrinh>> GetCongTrinhByChuyenGia(int chuyenGiaId)
        {
            var l = context.CongTrinhRepository.SearchCongTrinhByChuyenGiaId(chuyenGiaId).ToList();

            if (l.Count == 0)
            {
                return NotFound();
            }

            return l;
        }

        [HttpGet("GetGiaiThuongByChuyenGia/{chuyenGiaId}")]
        public ActionResult<IEnumerable<GiaiThuong>> GetGiaiThuongByChuyenGia(int chuyenGiaId)
        {
            var l = context.GiaiThuongRepository.SearchGiaiThuongByChuyenGiaId(chuyenGiaId).ToList();

            if (l.Count == 0)
            {
                return NotFound();
            }

            return l;
        }

        [HttpGet("GetHoatDongKhacByChuyenGia/{chuyenGiaId}")]
        public ActionResult<IEnumerable<HoatDongKhac>> GetHoatDongKhacByChuyenGia(int chuyenGiaId)
        {
            var l = context.HoatDongKhacRepository.SearchHoatDongKhacByChuyenGiaId(chuyenGiaId).ToList();

            if (l.Count == 0)
            {
                return NotFound();
            }

            return l;
        }

        [HttpGet("GetKinhNghiemByChuyenGia/{chuyenGiaId}")]
        public ActionResult<IEnumerable<KinhNghiem>> GetKinhNghiemByChuyenGia(int chuyenGiaId)
        {
            var l = context.KinhNghiemRepository.SearchKinhNghiemByChuyenGiaId(chuyenGiaId).ToList();

            if (l.Count == 0)
            {
                return NotFound();
            }

            return l;
        }

        [HttpGet("GetVanBangByChuyenGia/{chuyenGiaId}")]
        public ActionResult<IEnumerable<VanBang>> GetVanBangByChuyenGia(int chuyenGiaId)
        {
            var l = context.VanBangRepository.SearchVanBangByChuyenGiaId(chuyenGiaId).ToList();

            if (l.Count == 0)
            {
                return NotFound();
            }

            return l;
        }


        // PUT: api/ChuyenGias/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChuyenGiaAsync(int id, [FromForm] ChuyenGia chuyenGia)
        {
            if (id != chuyenGia.Id)
            {
                return BadRequest();
            }
            if (chuyenGia.ImageFile != null && chuyenGia.ImageFile.Length > 0)
            {
                if (!string.IsNullOrEmpty(chuyenGia.ImageName))
                {
                    imageService.DeleteImage(chuyenGia.ImageName);
                }
                chuyenGia.ImageName = await imageService.SaveImage(chuyenGia.ImageFile);
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context.ChuyenGiaRepository.Update(chuyenGia);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChuyenGiaExists(chuyenGia.Id))
                    {
                        return NotFound();
                    }
                }
                return NoContent();
            }

            return BadRequest(ModelState);
        }

        // POST: api/ChuyenGias
        [HttpPost]
        public async Task<ActionResult<ChuyenGia>> PostChuyenGiaAsync([FromForm] ChuyenGia chuyenGia)
        {
            if (chuyenGia.ImageFile != null && chuyenGia.ImageFile.Length > 0)
            {
                chuyenGia.ImageName = await imageService.SaveImage(chuyenGia.ImageFile);
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.ChuyenGiaRepository.Create(chuyenGia);
            context.SaveChanges();

            return CreatedAtAction("GetChuyenGia", new { id = chuyenGia.Id }, chuyenGia);
        }

        // DELETE: api/ChuyenGias/5
        [HttpDelete("{id}")]
        public IActionResult DeleteChuyenGia(int id)
        {
            try
            {
                var chuyenGia = context.ChuyenGiaRepository.Find(id);
                if (chuyenGia == null)
                {
                    return NotFound();
                }
                if (!string.IsNullOrEmpty(chuyenGia.ImageName))
                {
                    imageService.DeleteImage(chuyenGia.ImageName);
                }
                context.ChuyenGiaRepository.Delete(chuyenGia);
                context.SaveChanges();

                return NoContent();
            }
            catch (DbUpdateException)
            {
                return BadRequest("Foreign key constraint violation: Cannot delete this entity due to related records in other tables.");
            }
        }

        private bool ChuyenGiaExists(int id)
        {
            return (context.ChuyenGiaRepository.GetAll()?.Any(e => e.Id == id)).GetValueOrDefault();
        }


    }
}
