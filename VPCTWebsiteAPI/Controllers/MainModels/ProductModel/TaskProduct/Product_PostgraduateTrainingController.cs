using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.ProductModel.TaskProduct;
using VPCT.Repositories.Infrastructure;

namespace VPCTWebsiteAPI.Controllers.MainModels.ProductModel.TaskProduct
{
    [Route("api/[controller]")]
    [ApiController]
    public class Product_PostgraduateTrainingController(IUnitOfWork context) : ControllerBase
    {

        // GET: api/Product_PostgraduateTraining
        [HttpGet]
        public ActionResult<IEnumerable<Product_PostgraduateTraining>> GetProduct_PostgraduateTraining()
        {
            return context.Product_PostgraduateTraining_Repository.GetAll().ToList();
        }

        // GET: api/Product_PostgraduateTraining/5
        [HttpGet("{id}")]
        public ActionResult<Product_PostgraduateTraining> GetProduct_PostgraduateTraining(int id)
        {
            var product_PostgraduateTraining = context.Product_PostgraduateTraining_Repository.Find(id);

            if (product_PostgraduateTraining == null)
            {
                return NotFound();
            }

            return product_PostgraduateTraining;
        }
        [HttpGet("GetProduct_PostgraduateTrainingByNhiemVu/{nhiemVuId}")]
        public ActionResult<IEnumerable<Product_PostgraduateTraining>> GetProduct_PostgraduateTrainingByNhiemVu(int nhiemVuId)
        {
            var l = context.Product_PostgraduateTraining_Repository.SearchProduct_PostgraduateTrainingByNhiemVuId(nhiemVuId).ToList();

            if (l.Count == 0)
            {
                return NotFound();
            }

            return l;
        }
        // PUT: api/Product_PostgraduateTraining/5
        [HttpPut("{id}")]
        public IActionResult PutProduct_PostgraduateTraining(int id, Product_PostgraduateTraining product_PostgraduateTraining)
        {
            if (id != product_PostgraduateTraining.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context.Product_PostgraduateTraining_Repository.Update(product_PostgraduateTraining);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Product_PostgraduateTrainingExists(product_PostgraduateTraining.Id))
                    {
                        return NotFound();
                    }
                }
                return NoContent();
            }

            return BadRequest(ModelState);
        }

        // POST: api/Product_PostgraduateTraining
        [HttpPost]
        public ActionResult<Product_PostgraduateTraining> PostProduct_PostgraduateTraining(Product_PostgraduateTraining product_PostgraduateTraining)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.Product_PostgraduateTraining_Repository.Create(product_PostgraduateTraining);
            context.SaveChanges();

            return CreatedAtAction("GetProduct_PostgraduateTraining", new { id = product_PostgraduateTraining.Id }, product_PostgraduateTraining);
        }

        // DELETE: api/Product_PostgraduateTraining/5
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct_PostgraduateTraining(int id)
        {
            try
            {
                var product_PostgraduateTraining = context.Product_PostgraduateTraining_Repository.Find(id);
                if (product_PostgraduateTraining == null)
                {
                    return NotFound();
                }

                context.Product_PostgraduateTraining_Repository.Delete(product_PostgraduateTraining);
                context.SaveChanges();

                return NoContent();
            }
            catch (DbUpdateException)
            {
                return BadRequest("Foreign key constraint violation: Cannot delete this entity due to related records in other tables.");
            }
        }

        private bool Product_PostgraduateTrainingExists(int id)
        {
            return (context.Product_PostgraduateTraining_Repository.GetAll()?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
