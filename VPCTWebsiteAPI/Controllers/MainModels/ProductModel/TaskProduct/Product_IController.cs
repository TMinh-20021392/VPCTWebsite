using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.ProductModel.TaskProduct;
using VPCT.Repositories.Infrastructure;

namespace VPCTWebsiteAPI.Controllers.MainModels.ProductModel.TaskProduct
{
    [Route("api/[controller]")]
    [ApiController]
    public class Product_IController(IUnitOfWork context) : ControllerBase
    {

        // GET: api/Product_I
        [HttpGet]
        public ActionResult<IEnumerable<Product_I>> GetProductIs()
        {
            return context.Product_I_Repository.GetAll().ToList();
        }

        // GET: api/Product_I/5
        [HttpGet("{id}")]
        public ActionResult<Product_I> GetProductI(int id)
        {
            var product_I = context.Product_I_Repository.Find(id);

            if (product_I == null)
            {
                return NotFound();
            }

            return product_I;
        }
        [HttpGet("GetProduct_IByNhiemVu/{nhiemVuId}")]
        public ActionResult<IEnumerable<Product_I>> GetProduct_IByNhiemVu(int nhiemVuId)
        {
            var l = context.Product_I_Repository.SearchProduct_IByNhiemVuId(nhiemVuId).ToList();

            if (l.Count == 0)
            {
                return NotFound();
            }

            return l;
        }
        // PUT: api/Product_I/5
        [HttpPut("{id}")]
        public IActionResult PutProduct_I(int id, Product_I product_I)
        {
            if (id != product_I.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context.Product_I_Repository.Update(product_I);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Product_IExists(product_I.Id))
                    {
                        return NotFound();
                    }
                }
                return NoContent();
            }

            return BadRequest(ModelState);
        }

        // POST: api/Product_I
        [HttpPost]
        public ActionResult<Product_I> PostProduct_I(Product_I product_I)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.Product_I_Repository.Create(product_I);
            context.SaveChanges();

            return CreatedAtAction("GetProduct_I", new { id = product_I.Id }, product_I);
        }

        // DELETE: api/Product_I/5
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct_I(int id)
        {
            try
            {
                var product_I = context.Product_I_Repository.Find(id);
                if (product_I == null)
                {
                    return NotFound();
                }

                context.Product_I_Repository.Delete(product_I);
                context.SaveChanges();

                return NoContent();
            }
            catch (DbUpdateException)
            {
                return BadRequest("Foreign key constraint violation: Cannot delete this entity due to related records in other tables.");
            }
        }

        private bool Product_IExists(int id)
        {
            return (context.Product_I_Repository.GetAll()?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
