using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.ProductModel.TaskProduct;
using VPCT.Repositories.Infrastructure;

namespace VPCTWebsiteAPI.Controllers.MainModels.ProductModel.TaskProduct
{
    [Route("api/[controller]")]
    [ApiController]
    public class Product_IIController(IUnitOfWork context) : ControllerBase
    {

        // GET: api/Product_II
        [HttpGet]
        public ActionResult<IEnumerable<Product_II>> GetProduct_IIs()
        {
            return context.Product_II_Repository.GetAll().ToList();
        }

        // GET: api/Product_II/5
        [HttpGet("{id}")]
        public ActionResult<Product_II> GetProduct_II(int id)
        {
            var product_II = context.Product_II_Repository.Find(id);

            if (product_II == null)
            {
                return NotFound();
            }

            return product_II;
        }
        [HttpGet("GetProduct_IIByNhiemVu/{nhiemVuId}")]
        public ActionResult<IEnumerable<Product_II>> GetProduct_IIByNhiemVu(int nhiemVuId)
        {
            var l = context.Product_II_Repository.SearchProduct_IIByNhiemVuId(nhiemVuId).ToList();

            if (l.Count == 0)
            {
                return NotFound();
            }

            return l;
        }
        // PUT: api/Product_II/5
        [HttpPut("{id}")]
        public IActionResult PutProduct_II(int id, Product_II product_II)
        {
            if (id != product_II.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context.Product_II_Repository.Update(product_II);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Product_IIExists(product_II.Id))
                    {
                        return NotFound();
                    }
                }
                return NoContent();
            }

            return BadRequest(ModelState);
        }

        // POST: api/Product_II
        [HttpPost]
        public ActionResult<Product_II> PostProduct_II(Product_II product_II)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.Product_II_Repository.Create(product_II);
            context.SaveChanges();

            return CreatedAtAction("GetProduct_II", new { id = product_II.Id }, product_II);
        }

        // DELETE: api/Product_II/5
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct_II(int id)
        {
            try
            {
                var product_II = context.Product_II_Repository.Find(id);
                if (product_II == null)
                {
                    return NotFound();
                }

                context.Product_II_Repository.Delete(product_II);
                context.SaveChanges();

                return NoContent();
            }
            catch (DbUpdateException)
            {
                return BadRequest("Foreign key constraint violation: Cannot delete this entity due to related records in other tables.");
            }
        }

        private bool Product_IIExists(int id)
        {
            return (context.Product_II_Repository.GetAll()?.Any(e => e.Id == id)).GetValueOrDefault();

        }
    }
}
