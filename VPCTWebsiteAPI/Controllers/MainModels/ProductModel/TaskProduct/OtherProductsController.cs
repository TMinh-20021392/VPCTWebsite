using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.TaskModel;
using VPCT.Repositories.Infrastructure;

namespace VPCTWebsiteAPI.Controllers.MainModels.ProductModel.TaskProduct
{
    [Route("api/[controller]")]
    [ApiController]
    public class OtherProductsController(IUnitOfWork context) : ControllerBase
    {

        // GET: api/OtherProducts
        [HttpGet]
        public ActionResult<IEnumerable<OtherProducts>> GetOtherProducts()
        {
            return context.OtherProductsRepository.GetAll().ToList();
        }

        // GET: api/OtherProducts/5
        [HttpGet("{id}")]
        public ActionResult<OtherProducts> GetOtherProducts(int id)
        {
            var otherProducts = context.OtherProductsRepository.Find(id);

            if (otherProducts == null)
            {
                return NotFound();
            }

            return otherProducts;
        }

        [HttpGet("GetOtherProductByNhiemVu/{nhiemVuId}")]
        public ActionResult<IEnumerable<OtherProducts>> GetOtherProductByNhiemVu(int nhiemVuId)
        {
            var l = context.OtherProductsRepository.SearchOtherProductsByNhiemVuId(nhiemVuId).ToList();

            if (l.Count == 0)
            {
                return NotFound();
            }

            return l;
        }

        // PUT: api/OtherProducts/5
        [HttpPut("{id}")]
        public IActionResult PutOtherProducts(int id, OtherProducts otherProducts)
        {
            if (id != otherProducts.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context.OtherProductsRepository.Update(otherProducts);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OtherProductsExists(otherProducts.Id))
                    {
                        return NotFound();
                    }
                }
                return NoContent();
            }

            return BadRequest(ModelState);
        }

        // POST: api/OtherProducts
        [HttpPost]
        public ActionResult<OtherProducts> PostOtherProducts(OtherProducts otherProducts)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.OtherProductsRepository.Create(otherProducts);
            context.SaveChanges();

            return CreatedAtAction("GetOtherProducts", new { id = otherProducts.Id }, otherProducts);
        }

        // DELETE: api/OtherProducts/5
        [HttpDelete("{id}")]
        public IActionResult DeleteOtherProducts(int id)
        {
            var otherProducts = context.OtherProductsRepository.Find(id);
            if (otherProducts == null)
            {
                return NotFound();
            }

            context.OtherProductsRepository.Delete(otherProducts);
            context.SaveChanges();

            return NoContent();
        }

        private bool OtherProductsExists(int id)
        {
            return (context.OtherProductsRepository.GetAll()?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
