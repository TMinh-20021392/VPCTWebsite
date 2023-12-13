using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.ProductModel.TaskProduct;
using VPCT.Repositories.Infrastructure;

namespace VPCTWebsiteAPI.Controllers.MainModels.ProductModel.TaskProduct
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnershipsController(IUnitOfWork context) : ControllerBase
    {

        // GET: api/Ownerships
        [HttpGet]
        public ActionResult<IEnumerable<Ownership>> GetOwnerships()
        {
            return context.OwnershipRepository.GetAll().ToList();
        }

        // GET: api/Ownerships/5
        [HttpGet("{id}")]
        public ActionResult<Ownership> GetOwnership(int id)
        {
            var ownership = context.OwnershipRepository.Find(id);

            if (ownership == null)
            {
                return NotFound();
            }

            return ownership;
        }
        [HttpGet("GetOwnershipByNhiemVu/{nhiemVuId}")]
        public ActionResult<IEnumerable<Ownership>> GetOwnershipByNhiemVu(int nhiemVuId)
        {
            var l = context.OwnershipRepository.SearchOwnershipByNhiemVuId(nhiemVuId).ToList();

            if (l.Count == 0)
            {
                return NotFound();
            }

            return l;
        }
        // PUT: api/Ownerships/5
        [HttpPut("{id}")]
        public IActionResult PutOwnership(int id, Ownership ownership)
        {
            if (id != ownership.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context.OwnershipRepository.Update(ownership);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OwnershipExists(ownership.Id))
                    {
                        return NotFound();
                    }
                }
                return NoContent();
            }

            return BadRequest(ModelState);
        }

        // POST: api/Ownerships
        [HttpPost]
        public ActionResult<Ownership> PostOwnership(Ownership ownership)
        {
            context.OwnershipRepository.Create(ownership);
            context.SaveChanges();

            return CreatedAtAction("GetOwnership", new { id = ownership.Id }, ownership);
        }

        // DELETE: api/Ownerships/5
        [HttpDelete("{id}")]
        public IActionResult DeleteOwnership(int id)
        {
            var ownership = context.OwnershipRepository.Find(id);
            if (ownership == null)
            {
                return NotFound();
            }

            context.OwnershipRepository.Delete(ownership);
            context.SaveChanges();

            return NoContent();
        }

        private bool OwnershipExists(int id)
        {
            return (context.OwnershipRepository.GetAll()?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
