using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.ProductModel.TaskProduct;
using VPCT.Repositories.Infrastructure;

namespace VPCTWebsiteAPI.Controllers.MainModels.ProductModel.TaskProduct
{
    [Route("api/[controller]")]
    [ApiController]
    public class Product_IIIController(IUnitOfWork context) : ControllerBase
    {

        // GET: api/Product_III
        [HttpGet]
        public ActionResult<IEnumerable<Product_III>> GetProduct_IIIs()
        {
            return context.Product_III_Repository.GetAll().ToList();
        }

        // GET: api/Product_III/5
        [HttpGet("{id}")]
        public ActionResult<Product_III> GetProduct_III(int id)
        {
            var product_III = context.Product_III_Repository.Find(id);

            if (product_III == null)
            {
                return NotFound();
            }

            return product_III;
        }
        [HttpGet("GetProduct_IIIByNhiemVu/{nhiemVuId}")]
        public ActionResult<IEnumerable<Product_III>> GetProduct_IIIByNhiemVu(int nhiemVuId)
        {
            var l = context.Product_III_Repository.SearchProduct_IIIByNhiemVuId(nhiemVuId).ToList();

            if (l.Count == 0)
            {
                return NotFound();
            }

            return l;
        }
        // PUT: api/Product_III/5
        [HttpPut("{id}")]
        public IActionResult PutProduct_III(int id, Product_III product_III)
        {
            if (id != product_III.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context.Product_III_Repository.Update(product_III);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Product_IIIExists(product_III.Id))
                    {
                        return NotFound();
                    }
                }
                return NoContent();
            }

            return BadRequest(ModelState);
        }

        // POST: api/Product_III
        [HttpPost]
        public ActionResult<Product_III> PostProduct_III(Product_III product_III)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.Product_III_Repository.Create(product_III);
            context.SaveChanges();

            return CreatedAtAction("GetProduct_III", new { id = product_III.Id }, product_III);
        }

        // DELETE: api/Product_III/5
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct_III(int id)
        {
            try
            {
                var product_III = context.Product_III_Repository.Find(id);
                if (product_III == null)
                {
                    return NotFound();
                }

                context.Product_III_Repository.Delete(product_III);
                context.SaveChanges();

                return NoContent();
            }
            catch (DbUpdateException)
            {
                return BadRequest("Foreign key constraint violation: Cannot delete this entity due to related records in other tables.");
            }
        }

        private bool Product_IIIExists(int id)
        {
            return (context.Product_III_Repository.GetAll()?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
